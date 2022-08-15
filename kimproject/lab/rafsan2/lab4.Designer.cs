namespace rafsan2
{
    partial class lab4
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
            this.CE = new System.Windows.Forms.ListBox();
            this.ME = new System.Windows.Forms.ListBox();
            this.EEE = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.stuid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stuname = new System.Windows.Forms.TextBox();
            this.departmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facultycomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CE
            // 
            this.CE.FormattingEnabled = true;
            this.CE.ItemHeight = 15;
            this.CE.Location = new System.Drawing.Point(761, 105);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(181, 184);
            this.CE.TabIndex = 33;
            // 
            // ME
            // 
            this.ME.FormattingEnabled = true;
            this.ME.ItemHeight = 15;
            this.ME.Location = new System.Drawing.Point(555, 105);
            this.ME.Name = "ME";
            this.ME.Size = new System.Drawing.Size(181, 184);
            this.ME.TabIndex = 32;
            // 
            // EEE
            // 
            this.EEE.FormattingEnabled = true;
            this.EEE.ItemHeight = 15;
            this.EEE.Location = new System.Drawing.Point(357, 105);
            this.EEE.Name = "EEE";
            this.EEE.Size = new System.Drawing.Size(181, 184);
            this.EEE.TabIndex = 31;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(391, 327);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(83, 38);
            this.submit.TabIndex = 30;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(180, 277);
            this.stuid.Multiline = true;
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(134, 30);
            this.stuid.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Student Name";
            // 
            // stuname
            // 
            this.stuname.Location = new System.Drawing.Point(180, 215);
            this.stuname.Multiline = true;
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(134, 30);
            this.stuname.TabIndex = 26;
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
            this.departmentcomboBox.Location = new System.Drawing.Point(180, 162);
            this.departmentcomboBox.Name = "departmentcomboBox";
            this.departmentcomboBox.Size = new System.Drawing.Size(134, 23);
            this.departmentcomboBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Faculty";
            // 
            // facultycomboBox
            // 
            this.facultycomboBox.FormattingEnabled = true;
            this.facultycomboBox.Items.AddRange(new object[] {
            "EEE",
            "ME",
            "CE",
            ""});
            this.facultycomboBox.Location = new System.Drawing.Point(180, 98);
            this.facultycomboBox.Name = "facultycomboBox";
            this.facultycomboBox.Size = new System.Drawing.Size(134, 23);
            this.facultycomboBox.TabIndex = 22;
            this.facultycomboBox.SelectedIndexChanged += new System.EventHandler(this.facultycomboBox_SelectedIndexChanged);
            // 
            // lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 463);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.ME);
            this.Controls.Add(this.EEE);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stuname);
            this.Controls.Add(this.departmentcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facultycomboBox);
            this.Name = "lab4";
            this.Text = "lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox CE;
        private ListBox ME;
        private ListBox EEE;
        private Button submit;
        private TextBox stuid;
        private Label label7;
        private Label label6;
        private TextBox stuname;
        private ComboBox departmentcomboBox;
        private Label label4;
        private Label label3;
        private ComboBox facultycomboBox;
    }
}