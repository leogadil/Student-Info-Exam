namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentLastNameList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentFirstNameList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentIDList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.First_Name_Input = new System.Windows.Forms.TextBox();
            this.Last_Name_Input = new System.Windows.Forms.TextBox();
            this.ID_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(428, 52);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 25;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Last Name List";
            // 
            // StudentLastNameList
            // 
            this.StudentLastNameList.FormattingEnabled = true;
            this.StudentLastNameList.Location = new System.Drawing.Point(345, 109);
            this.StudentLastNameList.Name = "StudentLastNameList";
            this.StudentLastNameList.Size = new System.Drawing.Size(159, 95);
            this.StudentLastNameList.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "First Name List";
            // 
            // StudentFirstNameList
            // 
            this.StudentFirstNameList.FormattingEnabled = true;
            this.StudentFirstNameList.Location = new System.Drawing.Point(180, 109);
            this.StudentFirstNameList.Name = "StudentFirstNameList";
            this.StudentFirstNameList.Size = new System.Drawing.Size(159, 95);
            this.StudentFirstNameList.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Student ID List";
            // 
            // StudentIDList
            // 
            this.StudentIDList.FormattingEnabled = true;
            this.StudentIDList.Location = new System.Drawing.Point(15, 109);
            this.StudentIDList.Name = "StudentIDList";
            this.StudentIDList.Size = new System.Drawing.Size(159, 95);
            this.StudentIDList.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name *";
            // 
            // First_Name_Input
            // 
            this.First_Name_Input.Location = new System.Drawing.Point(345, 25);
            this.First_Name_Input.Name = "First_Name_Input";
            this.First_Name_Input.Size = new System.Drawing.Size(159, 20);
            this.First_Name_Input.TabIndex = 16;
            // 
            // Last_Name_Input
            // 
            this.Last_Name_Input.Location = new System.Drawing.Point(180, 25);
            this.Last_Name_Input.Name = "Last_Name_Input";
            this.Last_Name_Input.Size = new System.Drawing.Size(159, 20);
            this.Last_Name_Input.TabIndex = 15;
            // 
            // ID_Input
            // 
            this.ID_Input.Location = new System.Drawing.Point(15, 25);
            this.ID_Input.Name = "ID_Input";
            this.ID_Input.Size = new System.Drawing.Size(159, 20);
            this.ID_Input.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID *";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 218);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentLastNameList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentFirstNameList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentIDList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First_Name_Input);
            this.Controls.Add(this.Last_Name_Input);
            this.Controls.Add(this.ID_Input);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(535, 257);
            this.MinimumSize = new System.Drawing.Size(535, 257);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox StudentLastNameList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox StudentFirstNameList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox StudentIDList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox First_Name_Input;
        private System.Windows.Forms.TextBox Last_Name_Input;
        private System.Windows.Forms.TextBox ID_Input;
        private System.Windows.Forms.Label label1;
    }
}

