namespace MessariT15
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxSignLogin = new MessariT15.CustomControls.RJControls.RJTextBox();
            this.TBoxSignPassword = new MessariT15.CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new MessariT15.CustomControls.RJControls.RJButton();
            this.rjButton2 = new MessariT15.CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // TBoxSignLogin
            // 
            this.TBoxSignLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.TBoxSignLogin.BorderColor = System.Drawing.Color.White;
            this.TBoxSignLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.TBoxSignLogin.BorderSize = 0;
            this.TBoxSignLogin.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.TBoxSignLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TBoxSignLogin.Location = new System.Drawing.Point(17, 109);
            this.TBoxSignLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxSignLogin.Multiline = false;
            this.TBoxSignLogin.Name = "TBoxSignLogin";
            this.TBoxSignLogin.Padding = new System.Windows.Forms.Padding(7);
            this.TBoxSignLogin.PasswordChar = false;
            this.TBoxSignLogin.Size = new System.Drawing.Size(159, 36);
            this.TBoxSignLogin.TabIndex = 9;
            this.TBoxSignLogin.Texts = "";
            this.TBoxSignLogin.UnderlinedStyle = true;
            this.TBoxSignLogin._TextChanged += new System.EventHandler(this.TBoxSignLogin__TextChanged);
            // 
            // TBoxSignPassword
            // 
            this.TBoxSignPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.TBoxSignPassword.BorderColor = System.Drawing.Color.White;
            this.TBoxSignPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.TBoxSignPassword.BorderSize = 0;
            this.TBoxSignPassword.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.TBoxSignPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TBoxSignPassword.Location = new System.Drawing.Point(17, 166);
            this.TBoxSignPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxSignPassword.Multiline = false;
            this.TBoxSignPassword.Name = "TBoxSignPassword";
            this.TBoxSignPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TBoxSignPassword.PasswordChar = false;
            this.TBoxSignPassword.Size = new System.Drawing.Size(159, 36);
            this.TBoxSignPassword.TabIndex = 11;
            this.TBoxSignPassword.Texts = "";
            this.TBoxSignPassword.UnderlinedStyle = true;
            this.TBoxSignPassword._TextChanged += new System.EventHandler(this.TBoxSignPassword__TextChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(17, 217);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 12;
            this.rjButton1.Text = "Login in";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(30, 263);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(126, 26);
            this.rjButton2.TabIndex = 13;
            this.rjButton2.Text = "create acount";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(192, 301);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.TBoxSignPassword);
            this.Controls.Add(this.TBoxSignLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox TBoxSignLogin;
        private CustomControls.RJControls.RJTextBox TBoxSignPassword;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}