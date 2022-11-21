namespace MessariT15
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.BtnFavorites = new System.Windows.Forms.Button();
            this.BtnBriefcase = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.iblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rjButton1 = new MessariT15.CustomControls.RJControls.RJButton();
            this.rjTextBox1 = new MessariT15.CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnConverter);
            this.panel1.Controls.Add(this.BtnFavorites);
            this.panel1.Controls.Add(this.BtnBriefcase);
            this.panel1.Controls.Add(this.BtnList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 585);
            this.panel1.TabIndex = 0;
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(0, 537);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(171, 42);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.Leave += new System.EventHandler(this.BtnSettings_Leave);
            // 
            // BtnConverter
            // 
            this.BtnConverter.FlatAppearance.BorderSize = 0;
            this.BtnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConverter.ForeColor = System.Drawing.Color.White;
            this.BtnConverter.Location = new System.Drawing.Point(0, 277);
            this.BtnConverter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(167, 42);
            this.BtnConverter.TabIndex = 5;
            this.BtnConverter.Text = "Converter";
            this.BtnConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            this.BtnConverter.Leave += new System.EventHandler(this.BtnConverter_Leave);
            // 
            // BtnFavorites
            // 
            this.BtnFavorites.FlatAppearance.BorderSize = 0;
            this.BtnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFavorites.ForeColor = System.Drawing.Color.White;
            this.BtnFavorites.Location = new System.Drawing.Point(4, 229);
            this.BtnFavorites.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFavorites.Name = "BtnFavorites";
            this.BtnFavorites.Size = new System.Drawing.Size(163, 42);
            this.BtnFavorites.TabIndex = 4;
            this.BtnFavorites.Text = "Favorites";
            this.BtnFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFavorites.UseVisualStyleBackColor = true;
            this.BtnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            this.BtnFavorites.Leave += new System.EventHandler(this.BtnFavorites_Leave);
            // 
            // BtnBriefcase
            // 
            this.BtnBriefcase.FlatAppearance.BorderSize = 0;
            this.BtnBriefcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBriefcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBriefcase.ForeColor = System.Drawing.Color.White;
            this.BtnBriefcase.Location = new System.Drawing.Point(0, 181);
            this.BtnBriefcase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBriefcase.Name = "BtnBriefcase";
            this.BtnBriefcase.Size = new System.Drawing.Size(167, 42);
            this.BtnBriefcase.TabIndex = 3;
            this.BtnBriefcase.Text = "   Briefcase";
            this.BtnBriefcase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnBriefcase.UseVisualStyleBackColor = true;
            this.BtnBriefcase.Click += new System.EventHandler(this.BtnBriefcase_Click);
            this.BtnBriefcase.Leave += new System.EventHandler(this.BtnBriefcase_Leave);
            // 
            // BtnList
            // 
            this.BtnList.FlatAppearance.BorderSize = 0;
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnList.ForeColor = System.Drawing.Color.White;
            this.BtnList.Location = new System.Drawing.Point(0, 145);
            this.BtnList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(167, 42);
            this.BtnList.TabIndex = 2;
            this.BtnList.Text = "    List";
            this.BtnList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            this.BtnList.Leave += new System.EventHandler(this.BtnList_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 139);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MessariT15.Properties.Resources.Virtual_Reality;
            this.pictureBox1.Location = new System.Drawing.Point(48, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(174, 79);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1113, 500);
            this.PnlFormLoader.TabIndex = 7;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // iblTitle
            // 
            this.iblTitle.AutoSize = true;
            this.iblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.iblTitle.Location = new System.Drawing.Point(218, 9);
            this.iblTitle.Name = "iblTitle";
            this.iblTitle.Size = new System.Drawing.Size(138, 32);
            this.iblTitle.TabIndex = 4;
            this.iblTitle.Text = "MessariT";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1254, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.rjButton1.BorderColor = System.Drawing.Color.DarkMagenta;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rjButton1.Location = new System.Drawing.Point(678, 16);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(132, 29);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.Text = "Serch";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.rjTextBox1.BorderSize = 0;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rjTextBox1.Location = new System.Drawing.Point(384, 10);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(242, 31);
            this.rjTextBox1.TabIndex = 8;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "123";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1292, 585);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iblTitle);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Button BtnFavorites;
        private System.Windows.Forms.Button BtnBriefcase;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label iblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlFormLoader;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
    }
}

