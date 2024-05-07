using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation_Data_Check.Properties;

namespace Presentation_Data_Check
{
    public partial class Form1 : Form
    {
        SqlConnection myConn ;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            try { this.Text += " (" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() + ")"; } catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a single test");
                return;
            }

            /*
             *  select distinct data_symbolset, data_computername, data_scannerdata, count(data_symbolset) as 'scans'
                from testdata where data_testname = 'centertest2'
                and data_scannerdata not like 'ID%' and data_scannerdata <> 'PE Event'
                group by 
                data_symbolset, data_computername, data_scannerdata
                order by Data_SymbolSet, Data_ComputerName
            */

            string mySQL = "select distinct data_symbolset, data_computername, data_scannername, data_scannerdata, count(data_symbolset) as 'scans' " +
                           "from testdata where data_testname = '" + listBox1.SelectedItem + "' " +
                           "and data_scannerdata not like 'ID%' and data_scannerdata<> 'PE Event' " +
                           "group by " +
                           "data_symbolset, data_computername,  data_scannername, data_scannerdata ";

            if (rbSort1.Checked)
                           mySQL = mySQL + " order by Data_SymbolSet, Data_ComputerName";
            if (rbSort2.Checked)
                           mySQL = mySQL + " order by Data_ComputerName, Data_SymbolSet";
            if (rbSort3.Checked)
                           mySQL = mySQL + " order by Data_scannername, Data_SymbolSet";


            SqlCommand myCMD = new SqlCommand(mySQL, myConn);
            try
            {
                SqlDataReader myReader = myCMD.ExecuteReader();
                if(myReader.HasRows)
                {
                    while(myReader.Read())
                    {
                        dataGridView1.Rows.Add(new object[] { myReader[0].ToString(),
                                                              myReader[1].ToString(),
                                                              myReader[2].ToString(),
                                                              myReader[3].ToString(),
                                                              myReader[4].ToString()});
                    }
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(txtDBConn.Text);
                myConn.Open();

                LoadTests();

                button1.Enabled = false;
                btnGetTests.Enabled = true;
                btnQuery.Enabled = true;
                btnCopy.Enabled = true;
                btnClear.Enabled = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetTests_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UpdateListBox("");
            LoadTests();
            Cursor.Current = Cursors.Default;
        }

        private void LoadTests()
        {
            string mySQLStr = "select distinct(data_Testname) from testdata order by data_testname";
            SqlCommand myCMD = new SqlCommand(mySQLStr, myConn);
            try
            {
                SqlDataReader myReader = myCMD.ExecuteReader();
                if(myReader.HasRows)
                {
                    while(myReader.Read())
                    {
                        UpdateListBox(myReader[0].ToString());
                    }    
                }
                myReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void UpdateListBoxd(string data);
        private void UpdateListBox(string data)
        {
            if(listBox1.InvokeRequired)
            {

            }
            else
            {
                if (data == "")
                    listBox1.Items.Clear();
                else
                    listBox1.Items.Add(data);
            }
        }

        private void GetSettings()
        {
            txtDBConn.Text = Settings.Default.dbconn;
        }

        private void SaveSettings()
        {
            Settings.Default.dbconn = txtDBConn.Text;
            Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            try { myConn.Close(); } catch { }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            Clipboard.SetDataObject(dataObj, true);
        }
    }
}
