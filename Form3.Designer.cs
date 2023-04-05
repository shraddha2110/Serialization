namespace WindowsAppDemo
{
    partial class Form3
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
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.txtStudentPercentage = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentRollno = new System.Windows.Forms.TextBox();
            this.lblStudentPercentage = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentRollno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(284, 366);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(114, 23);
            this.btnJSONWrite.TabIndex = 27;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(408, 366);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(111, 23);
            this.btnJSONRead.TabIndex = 26;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(284, 307);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(114, 23);
            this.btnSOAPWrite.TabIndex = 25;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(408, 307);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(111, 23);
            this.btnSOAPRead.TabIndex = 24;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(284, 249);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(114, 23);
            this.btnXMLWrite.TabIndex = 23;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(408, 249);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(111, 23);
            this.btnXMLRead.TabIndex = 22;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(408, 199);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(111, 23);
            this.btnBinaryRead.TabIndex = 21;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(284, 199);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(114, 23);
            this.btnBinaryWrite.TabIndex = 20;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // txtStudentPercentage
            // 
            this.txtStudentPercentage.Location = new System.Drawing.Point(408, 145);
            this.txtStudentPercentage.Name = "txtStudentPercentage";
            this.txtStudentPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtStudentPercentage.TabIndex = 19;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(408, 104);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 18;
            // 
            // txtStudentRollno
            // 
            this.txtStudentRollno.Location = new System.Drawing.Point(408, 62);
            this.txtStudentRollno.Name = "txtStudentRollno";
            this.txtStudentRollno.Size = new System.Drawing.Size(100, 22);
            this.txtStudentRollno.TabIndex = 17;
            // 
            // lblStudentPercentage
            // 
            this.lblStudentPercentage.AutoSize = true;
            this.lblStudentPercentage.Location = new System.Drawing.Point(281, 145);
            this.lblStudentPercentage.Name = "lblStudentPercentage";
            this.lblStudentPercentage.Size = new System.Drawing.Size(125, 16);
            this.lblStudentPercentage.TabIndex = 16;
            this.lblStudentPercentage.Text = "Student Percentage";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(281, 104);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(92, 16);
            this.lblStudentName.TabIndex = 15;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblStudentRollno
            // 
            this.lblStudentRollno.AutoSize = true;
            this.lblStudentRollno.Location = new System.Drawing.Point(281, 62);
            this.lblStudentRollno.Name = "lblStudentRollno";
            this.lblStudentRollno.Size = new System.Drawing.Size(94, 16);
            this.lblStudentRollno.TabIndex = 14;
            this.lblStudentRollno.Text = "Student Rollno";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtStudentPercentage);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentRollno);
            this.Controls.Add(this.lblStudentPercentage);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentRollno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.TextBox txtStudentPercentage;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentRollno;
        private System.Windows.Forms.Label lblStudentPercentage;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentRollno;
    }
}