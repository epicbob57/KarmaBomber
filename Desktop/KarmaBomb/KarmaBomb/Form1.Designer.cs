namespace KarmaBomb
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
            this.getInfo = new System.Windows.Forms.Button();
            this.userT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bombButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.upRadio = new System.Windows.Forms.RadioButton();
            this.downRadio = new System.Windows.Forms.RadioButton();
            this.postCheck = new System.Windows.Forms.CheckBox();
            this.comCheck = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(109, 1);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(75, 23);
            this.getInfo.TabIndex = 0;
            this.getInfo.Text = "Get user info";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.Info_Click);
            // 
            // userT
            // 
            this.userT.Location = new System.Drawing.Point(3, 1);
            this.userT.Name = "userT";
            this.userT.Size = new System.Drawing.Size(100, 20);
            this.userT.TabIndex = 1;
            this.userT.TextChanged += new System.EventHandler(this.userT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " ";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(64, 90);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(64, 116);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:\r\n\r\nPassword:";
            this.label2.Visible = false;
            // 
            // bombButton
            // 
            this.bombButton.Location = new System.Drawing.Point(185, 176);
            this.bombButton.Name = "bombButton";
            this.bombButton.Size = new System.Drawing.Size(85, 42);
            this.bombButton.TabIndex = 6;
            this.bombButton.Text = "KarmaBomb";
            this.bombButton.UseVisualStyleBackColor = true;
            this.bombButton.Visible = false;
            this.bombButton.Click += new System.EventHandler(this.bombButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Options:";
            this.label3.Visible = false;
            // 
            // upRadio
            // 
            this.upRadio.AutoSize = true;
            this.upRadio.Location = new System.Drawing.Point(16, 178);
            this.upRadio.Name = "upRadio";
            this.upRadio.Size = new System.Drawing.Size(60, 17);
            this.upRadio.TabIndex = 8;
            this.upRadio.TabStop = true;
            this.upRadio.Text = "Upvote";
            this.upRadio.UseVisualStyleBackColor = true;
            this.upRadio.Visible = false;
            // 
            // downRadio
            // 
            this.downRadio.AutoSize = true;
            this.downRadio.Location = new System.Drawing.Point(16, 201);
            this.downRadio.Name = "downRadio";
            this.downRadio.Size = new System.Drawing.Size(74, 17);
            this.downRadio.TabIndex = 9;
            this.downRadio.TabStop = true;
            this.downRadio.Text = "Downvote";
            this.downRadio.UseVisualStyleBackColor = true;
            this.downRadio.Visible = false;
            // 
            // postCheck
            // 
            this.postCheck.AutoSize = true;
            this.postCheck.Location = new System.Drawing.Point(104, 178);
            this.postCheck.Name = "postCheck";
            this.postCheck.Size = new System.Drawing.Size(52, 17);
            this.postCheck.TabIndex = 10;
            this.postCheck.Text = "Posts";
            this.postCheck.UseVisualStyleBackColor = true;
            this.postCheck.Visible = false;
            // 
            // comCheck
            // 
            this.comCheck.AutoSize = true;
            this.comCheck.Location = new System.Drawing.Point(104, 201);
            this.comCheck.Name = "comCheck";
            this.comCheck.Size = new System.Drawing.Size(75, 17);
            this.comCheck.TabIndex = 11;
            this.comCheck.Text = "Comments";
            this.comCheck.UseVisualStyleBackColor = true;
            this.comCheck.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 15);
            this.progressBar1.TabIndex = 12;
            // 
            // progLabel
            // 
            this.progLabel.AutoSize = true;
            this.progLabel.Location = new System.Drawing.Point(4, 242);
            this.progLabel.Name = "progLabel";
            this.progLabel.Size = new System.Drawing.Size(10, 13);
            this.progLabel.TabIndex = 13;
            this.progLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comCheck);
            this.Controls.Add(this.postCheck);
            this.Controls.Add(this.downRadio);
            this.Controls.Add(this.upRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bombButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userT);
            this.Controls.Add(this.getInfo);
            this.Name = "Form1";
            this.Text = "KarmaBomber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getInfo;
        private System.Windows.Forms.TextBox userT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bombButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton upRadio;
        private System.Windows.Forms.RadioButton downRadio;
        private System.Windows.Forms.CheckBox postCheck;
        private System.Windows.Forms.CheckBox comCheck;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progLabel;
    }
}

