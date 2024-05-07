
namespace Presentation_Data_Check
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtDBConn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGetTests = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rbSort1 = new System.Windows.Forms.RadioButton();
            this.rbSort2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scanner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSort3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Enabled = false;
            this.btnQuery.Location = new System.Drawing.Point(289, 148);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(92, 54);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Run Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtDBConn
            // 
            this.txtDBConn.Location = new System.Drawing.Point(147, 27);
            this.txtDBConn.Name = "txtDBConn";
            this.txtDBConn.Size = new System.Drawing.Size(654, 26);
            this.txtDBConn.TabIndex = 19;
            this.txtDBConn.Text = "Server=DESKTOP-N0T5PRC\\SQLEXPRESS;Database=steve_test;Trusted_Connection=True;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "SQL Connection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 524);
            this.listBox1.TabIndex = 22;
            // 
            // btnGetTests
            // 
            this.btnGetTests.Enabled = false;
            this.btnGetTests.Location = new System.Drawing.Point(289, 74);
            this.btnGetTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetTests.Name = "btnGetTests";
            this.btnGetTests.Size = new System.Drawing.Size(92, 54);
            this.btnGetTests.TabIndex = 23;
            this.btnGetTests.Text = "Get Tests";
            this.btnGetTests.UseVisualStyleBackColor = true;
            this.btnGetTests.Click += new System.EventHandler(this.btnGetTests_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Card,
            this.Computer,
            this.Scanner,
            this.Data,
            this.Scans});
            this.dataGridView1.Location = new System.Drawing.Point(388, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(999, 592);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(1095, 27);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 26);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear Grid";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(288, 219);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(92, 52);
            this.btnCopy.TabIndex = 26;
            this.btnCopy.Text = "Copy Grid";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rbSort1
            // 
            this.rbSort1.AutoSize = true;
            this.rbSort1.Checked = true;
            this.rbSort1.Location = new System.Drawing.Point(298, 304);
            this.rbSort1.Name = "rbSort1";
            this.rbSort1.Size = new System.Drawing.Size(70, 24);
            this.rbSort1.TabIndex = 27;
            this.rbSort1.TabStop = true;
            this.rbSort1.Text = "Sort 1";
            this.rbSort1.UseVisualStyleBackColor = true;
            // 
            // rbSort2
            // 
            this.rbSort2.AutoSize = true;
            this.rbSort2.Location = new System.Drawing.Point(298, 399);
            this.rbSort2.Name = "rbSort2";
            this.rbSort2.Size = new System.Drawing.Size(70, 24);
            this.rbSort2.TabIndex = 28;
            this.rbSort2.TabStop = true;
            this.rbSort2.Text = "Sort 2";
            this.rbSort2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(297, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 49);
            this.label2.TabIndex = 29;
            this.label2.Text = "Card, Computer";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(297, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 49);
            this.label3.TabIndex = 30;
            this.label3.Text = "Computer, Card";
            // 
            // Card
            // 
            this.Card.HeaderText = "Card ID";
            this.Card.Name = "Card";
            this.Card.ReadOnly = true;
            // 
            // Computer
            // 
            this.Computer.HeaderText = "Computer";
            this.Computer.Name = "Computer";
            this.Computer.ReadOnly = true;
            this.Computer.Width = 125;
            // 
            // Scanner
            // 
            this.Scanner.HeaderText = "Scanner";
            this.Scanner.Name = "Scanner";
            this.Scanner.ReadOnly = true;
            this.Scanner.Width = 200;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 475;
            // 
            // Scans
            // 
            this.Scans.HeaderText = "Scans";
            this.Scans.Name = "Scans";
            this.Scans.ReadOnly = true;
            this.Scans.Width = 75;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(297, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 49);
            this.label4.TabIndex = 32;
            this.label4.Text = "Scanner, Card";
            // 
            // rbSort3
            // 
            this.rbSort3.AutoSize = true;
            this.rbSort3.Location = new System.Drawing.Point(298, 488);
            this.rbSort3.Name = "rbSort3";
            this.rbSort3.Size = new System.Drawing.Size(70, 24);
            this.rbSort3.TabIndex = 31;
            this.rbSort3.TabStop = true;
            this.rbSort3.Text = "Sort 3";
            this.rbSort3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbSort3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSort2);
            this.Controls.Add(this.rbSort1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetTests);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDBConn);
            this.Controls.Add(this.btnQuery);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation Scanner Data Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtDBConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGetTests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RadioButton rbSort1;
        private System.Windows.Forms.RadioButton rbSort2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scanner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSort3;
    }
}

