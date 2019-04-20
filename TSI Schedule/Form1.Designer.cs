namespace TSI_Schedule
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.Friend2LessBtn = new System.Windows.Forms.Button();
            this.FriendLessBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MyLesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactsUI1 = new TSI_Schedule.ContactsUI();
            this.noInternet1 = new TSI_Schedule.NoInternet();
            this.myLessons2 = new TSI_Schedule.MyLessons();
            this.myLessons1 = new TSI_Schedule.MyLessons();
            this.settingsUC1 = new TSI_Schedule.SettingsUC();
            this.myLessons3 = new TSI_Schedule.MyLessons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.Friend2LessBtn);
            this.panel1.Controls.Add(this.FriendLessBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.MyLesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 722);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(116)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 115);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 82);
            this.SidePanel.TabIndex = 2;
            // 
            // ContactBtn
            // 
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactBtn.ForeColor = System.Drawing.Color.White;
            this.ContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("ContactBtn.Image")));
            this.ContactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.Location = new System.Drawing.Point(23, 457);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(266, 82);
            this.ContactBtn.TabIndex = 4;
            this.ContactBtn.Text = "    Контакты";
            this.ContactBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(23, 373);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(266, 82);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.Text = "    Настройки";
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Friend2LessBtn
            // 
            this.Friend2LessBtn.FlatAppearance.BorderSize = 0;
            this.Friend2LessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friend2LessBtn.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friend2LessBtn.ForeColor = System.Drawing.Color.White;
            this.Friend2LessBtn.Image = ((System.Drawing.Image)(resources.GetObject("Friend2LessBtn.Image")));
            this.Friend2LessBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Friend2LessBtn.Location = new System.Drawing.Point(23, 287);
            this.Friend2LessBtn.Name = "Friend2LessBtn";
            this.Friend2LessBtn.Size = new System.Drawing.Size(266, 82);
            this.Friend2LessBtn.TabIndex = 4;
            this.Friend2LessBtn.Text = "    Уроки друга 2";
            this.Friend2LessBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Friend2LessBtn.UseVisualStyleBackColor = true;
            this.Friend2LessBtn.Click += new System.EventHandler(this.Friend2LessBtn_Click);
            // 
            // FriendLessBtn
            // 
            this.FriendLessBtn.FlatAppearance.BorderSize = 0;
            this.FriendLessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendLessBtn.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendLessBtn.ForeColor = System.Drawing.Color.White;
            this.FriendLessBtn.Image = ((System.Drawing.Image)(resources.GetObject("FriendLessBtn.Image")));
            this.FriendLessBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FriendLessBtn.Location = new System.Drawing.Point(23, 201);
            this.FriendLessBtn.Name = "FriendLessBtn";
            this.FriendLessBtn.Size = new System.Drawing.Size(266, 82);
            this.FriendLessBtn.TabIndex = 4;
            this.FriendLessBtn.Text = "    Уроки друга";
            this.FriendLessBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FriendLessBtn.UseVisualStyleBackColor = true;
            this.FriendLessBtn.Click += new System.EventHandler(this.FriendLessBtn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(23, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "   Мое расписание";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MyLesButton
            // 
            this.MyLesButton.FlatAppearance.BorderSize = 0;
            this.MyLesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyLesButton.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyLesButton.ForeColor = System.Drawing.Color.White;
            this.MyLesButton.Image = ((System.Drawing.Image)(resources.GetObject("MyLesButton.Image")));
            this.MyLesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyLesButton.Location = new System.Drawing.Point(23, 115);
            this.MyLesButton.Name = "MyLesButton";
            this.MyLesButton.Size = new System.Drawing.Size(266, 82);
            this.MyLesButton.TabIndex = 3;
            this.MyLesButton.Text = "    Мои  уроки";
            this.MyLesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyLesButton.UseVisualStyleBackColor = true;
            this.MyLesButton.Click += new System.EventHandler(this.MyLesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(116)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(289, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 81);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(400, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "TSI Schedule";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(835, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 36);
            this.button3.TabIndex = 6;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(878, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 36);
            this.button1.TabIndex = 5;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // contactsUI1
            // 
            this.contactsUI1.Location = new System.Drawing.Point(289, 80);
            this.contactsUI1.Name = "contactsUI1";
            this.contactsUI1.Size = new System.Drawing.Size(937, 641);
            this.contactsUI1.TabIndex = 7;
            // 
            // noInternet1
            // 
            this.noInternet1.BackColor = System.Drawing.Color.White;
            this.noInternet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noInternet1.Location = new System.Drawing.Point(491, 152);
            this.noInternet1.Name = "noInternet1";
            this.noInternet1.Size = new System.Drawing.Size(513, 416);
            this.noInternet1.TabIndex = 6;
            // 
            // myLessons2
            // 
            this.myLessons2.Location = new System.Drawing.Point(289, 80);
            this.myLessons2.Name = "myLessons2";
            this.myLessons2.Size = new System.Drawing.Size(937, 695);
            this.myLessons2.TabIndex = 3;
            // 
            // myLessons1
            // 
            this.myLessons1.Location = new System.Drawing.Point(289, 80);
            this.myLessons1.Name = "myLessons1";
            this.myLessons1.Size = new System.Drawing.Size(937, 695);
            this.myLessons1.TabIndex = 2;
            // 
            // settingsUC1
            // 
            this.settingsUC1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsUC1.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsUC1.Location = new System.Drawing.Point(289, 80);
            this.settingsUC1.Margin = new System.Windows.Forms.Padding(4);
            this.settingsUC1.Name = "settingsUC1";
            this.settingsUC1.Size = new System.Drawing.Size(937, 641);
            this.settingsUC1.TabIndex = 5;
            // 
            // myLessons3
            // 
            this.myLessons3.Location = new System.Drawing.Point(289, 80);
            this.myLessons3.Name = "myLessons3";
            this.myLessons3.Size = new System.Drawing.Size(937, 695);
            this.myLessons3.TabIndex = 4;
            this.myLessons3.Load += new System.EventHandler(this.myLessons3_Load);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1226, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contactsUI1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noInternet1);
            this.Controls.Add(this.myLessons2);
            this.Controls.Add(this.myLessons1);
            this.Controls.Add(this.settingsUC1);
            this.Controls.Add(this.myLessons3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MyLesButton;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button Friend2LessBtn;
        private System.Windows.Forms.Button FriendLessBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SidePanel;
        private MyLessons myLessons1;
        private MyLessons myLessons2;
        private MyLessons myLessons3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private SettingsUC settingsUC1;
        private NoInternet noInternet1;
        private ContactsUI contactsUI1;
        private System.Windows.Forms.Button ContactBtn;
    }
}

