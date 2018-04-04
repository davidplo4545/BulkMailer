namespace BulkMailer
{
    partial class MainWindow
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
            this.userTxt = new System.Windows.Forms.TextBox();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.bodyTxt = new System.Windows.Forms.TextBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.bodyLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.emailLst = new System.Windows.Forms.ListBox();
            this.pswrdLbl = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.GroupBox();
            this.msgBox = new System.Windows.Forms.GroupBox();
            this.userBox.SuspendLayout();
            this.msgBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(131, 26);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(217, 22);
            this.userTxt.TabIndex = 0;
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(449, 58);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(268, 22);
            this.toTxt.TabIndex = 1;
            // 
            // bodyTxt
            // 
            this.bodyTxt.Location = new System.Drawing.Point(10, 90);
            this.bodyTxt.Multiline = true;
            this.bodyTxt.Name = "bodyTxt";
            this.bodyTxt.Size = new System.Drawing.Size(389, 167);
            this.bodyTxt.TabIndex = 2;
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(131, 28);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(217, 22);
            this.subjectTxt.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sendBtn.Location = new System.Drawing.Point(531, 332);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(102, 51);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(7, 26);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(106, 17);
            this.userLbl.TabIndex = 5;
            this.userLbl.Text = "Full Email User:";
            // 
            // bodyLbl
            // 
            this.bodyLbl.AutoSize = true;
            this.bodyLbl.Location = new System.Drawing.Point(6, 67);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.Size = new System.Drawing.Size(44, 17);
            this.bodyLbl.TabIndex = 6;
            this.bodyLbl.Text = "Body:";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(54, 28);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(59, 17);
            this.subjectLbl.TabIndex = 7;
            this.subjectLbl.Text = "Subject:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(446, 38);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(29, 17);
            this.toLbl.TabIndex = 8;
            this.toLbl.Text = "To:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(131, 65);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(217, 22);
            this.passwordTxt.TabIndex = 9;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeBtn.Location = new System.Drawing.Point(641, 332);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(76, 36);
            this.removeBtn.TabIndex = 10;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addBtn.Location = new System.Drawing.Point(449, 332);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 36);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // emailLst
            // 
            this.emailLst.FormattingEnabled = true;
            this.emailLst.ItemHeight = 16;
            this.emailLst.Location = new System.Drawing.Point(449, 98);
            this.emailLst.Name = "emailLst";
            this.emailLst.Size = new System.Drawing.Size(268, 212);
            this.emailLst.TabIndex = 12;
            // 
            // pswrdLbl
            // 
            this.pswrdLbl.AutoSize = true;
            this.pswrdLbl.Location = new System.Drawing.Point(40, 68);
            this.pswrdLbl.Name = "pswrdLbl";
            this.pswrdLbl.Size = new System.Drawing.Size(73, 17);
            this.pswrdLbl.TabIndex = 13;
            this.pswrdLbl.Text = "Password:";
            // 
            // userBox
            // 
            this.userBox.Controls.Add(this.passwordTxt);
            this.userBox.Controls.Add(this.pswrdLbl);
            this.userBox.Controls.Add(this.userTxt);
            this.userBox.Controls.Add(this.userLbl);
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(12, 23);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(414, 101);
            this.userBox.TabIndex = 14;
            this.userBox.TabStop = false;
            this.userBox.Text = "User Settings";
            // 
            // msgBox
            // 
            this.msgBox.Controls.Add(this.subjectTxt);
            this.msgBox.Controls.Add(this.subjectLbl);
            this.msgBox.Controls.Add(this.bodyLbl);
            this.msgBox.Controls.Add(this.bodyTxt);
            this.msgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox.Location = new System.Drawing.Point(12, 144);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(414, 276);
            this.msgBox.TabIndex = 15;
            this.msgBox.TabStop = false;
            this.msgBox.Text = "Message Settings:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 423);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.emailLst);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.toTxt);
            this.Name = "MainWindow";
            this.Text = "Bulk Mailer";
            this.userBox.ResumeLayout(false);
            this.userBox.PerformLayout();
            this.msgBox.ResumeLayout(false);
            this.msgBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.TextBox bodyTxt;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label bodyLbl;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox emailLst;
        private System.Windows.Forms.Label pswrdLbl;
        private System.Windows.Forms.GroupBox userBox;
        private System.Windows.Forms.GroupBox msgBox;
    }
}

