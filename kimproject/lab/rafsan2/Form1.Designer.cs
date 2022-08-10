namespace rafsan2
{
    partial class bar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.secoundnumber = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultshow = new System.Windows.Forms.TextBox();
            this.fristnumber = new System.Windows.Forms.TextBox();
            this.facultycomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stuname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stuid = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.EEE = new System.Windows.Forms.ListBox();
            this.ME = new System.Windows.Forms.ListBox();
            this.CE = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secoundnumber
            // 
            this.secoundnumber.Location = new System.Drawing.Point(170, 78);
            this.secoundnumber.Multiline = true;
            this.secoundnumber.Name = "secoundnumber";
            this.secoundnumber.Size = new System.Drawing.Size(134, 27);
            this.secoundnumber.TabIndex = 0;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number1.Location = new System.Drawing.Point(12, 32);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(142, 30);
            this.number1.TabIndex = 1;
            this.number1.Text = "Frist Number";
            this.number1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number2.Location = new System.Drawing.Point(16, 75);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(138, 30);
            this.number2.TabIndex = 2;
            this.number2.Text = "2nd Number";
            this.number2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(194, 153);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(83, 38);
            this.result.TabIndex = 4;
            this.result.Text = "Result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // resultshow
            // 
            this.resultshow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resultshow.Location = new System.Drawing.Point(170, 120);
            this.resultshow.Multiline = true;
            this.resultshow.Name = "resultshow";
            this.resultshow.ReadOnly = true;
            this.resultshow.Size = new System.Drawing.Size(134, 27);
            this.resultshow.TabIndex = 6;
            this.resultshow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fristnumber
            // 
            this.fristnumber.Location = new System.Drawing.Point(170, 32);
            this.fristnumber.Multiline = true;
            this.fristnumber.Name = "fristnumber";
            this.fristnumber.Size = new System.Drawing.Size(134, 30);
            this.fristnumber.TabIndex = 7;
            this.fristnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // facultycomboBox
            // 
            this.facultycomboBox.FormattingEnabled = true;
            this.facultycomboBox.Items.AddRange(new object[] {
            "EEE",
            "ME",
            "CE",
            ""});
            this.facultycomboBox.Location = new System.Drawing.Point(194, 247);
            this.facultycomboBox.Name = "facultycomboBox";
            this.facultycomboBox.Size = new System.Drawing.Size(134, 23);
            this.facultycomboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "=================LAB 4===============";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Faculty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Department";
            // 
            // departmentcomboBox
            // 
            this.departmentcomboBox.FormattingEnabled = true;
            this.departmentcomboBox.Items.AddRange(new object[] {
            "EEE",
            "CSE",
            "ME",
            "CFE",
            "IPE",
            "TE",
            "CE",
            "ARCH"});
            this.departmentcomboBox.Location = new System.Drawing.Point(194, 304);
            this.departmentcomboBox.Name = "departmentcomboBox";
            this.departmentcomboBox.Size = new System.Drawing.Size(134, 23);
            this.departmentcomboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(308, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "=================LAB 1===============";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stuname
            // 
            this.stuname.Location = new System.Drawing.Point(194, 357);
            this.stuname.Multiline = true;
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(134, 30);
            this.stuname.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Student Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(194, 419);
            this.stuid.Multiline = true;
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(134, 30);
            this.stuid.TabIndex = 17;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(432, 469);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(83, 38);
            this.submit.TabIndex = 18;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EEE
            // 
            this.EEE.FormattingEnabled = true;
            this.EEE.ItemHeight = 15;
            this.EEE.Location = new System.Drawing.Point(398, 247);
            this.EEE.Name = "EEE";
            this.EEE.Size = new System.Drawing.Size(181, 184);
            this.EEE.TabIndex = 19;
            this.EEE.SelectedIndexChanged += new System.EventHandler(this.EEE_SelectedIndexChanged);
            // 
            // ME
            // 
            this.ME.FormattingEnabled = true;
            this.ME.ItemHeight = 15;
            this.ME.Location = new System.Drawing.Point(596, 247);
            this.ME.Name = "ME";
            this.ME.Size = new System.Drawing.Size(181, 184);
            this.ME.TabIndex = 20;
            // 
            // CE
            // 
            this.CE.FormattingEnabled = true;
            this.CE.ItemHeight = 15;
            this.CE.Location = new System.Drawing.Point(802, 247);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(181, 184);
            this.CE.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(468, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "EEE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(669, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "ME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(865, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "CE";
            // 
            // bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.ME);
            this.Controls.Add(this.EEE);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stuname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facultycomboBox);
            this.Controls.Add(this.fristnumber);
            this.Controls.Add(this.resultshow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.secoundnumber);
            this.Name = "bar";
            this.Text = "Rafsan Jani Projects";
            this.Load += new System.EventHandler(this.bar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox secoundnumber;
        private Label number1;
        private Label number2;
        private Button result;
        private Label label1;
        private TextBox resultshow;
        private TextBox fristnumber;
        private ComboBox facultycomboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox departmentcomboBox;
        private Label label5;
        private TextBox stuname;
        private Label label6;
        private Label label7;
        private TextBox stuid;
        private Button submit;
        private ListBox EEE;
        private ListBox ME;
        private ListBox CE;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}