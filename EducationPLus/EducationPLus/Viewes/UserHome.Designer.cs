namespace EducationPLus.Viewes
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.headPanel = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logOutUserButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.education = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.headPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headPanel.BackgroundImage")));
            this.headPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headPanel.Controls.Add(this.icon);
            this.headPanel.Controls.Add(this.email);
            this.headPanel.Controls.Add(this.username);
            this.headPanel.Controls.Add(this.settingsButton);
            this.headPanel.Controls.Add(this.logOutUserButton);
            this.headPanel.Controls.Add(this.button2);
            this.headPanel.Controls.Add(this.button1);
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Controls.Add(this.education);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(906, 60);
            this.headPanel.TabIndex = 0;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Location = new System.Drawing.Point(648, 13);
            this.icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(38, 34);
            this.icon.TabIndex = 9;
            this.icon.UseVisualStyleBackColor = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Location = new System.Drawing.Point(692, 32);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(36, 15);
            this.email.TabIndex = 8;
            this.email.Text = "email";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(692, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(59, 15);
            this.username.TabIndex = 7;
            this.username.Text = "username";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(864, 13);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 28);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // logOutUserButton
            // 
            this.logOutUserButton.BackColor = System.Drawing.Color.YellowGreen;
            this.logOutUserButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutUserButton.Location = new System.Drawing.Point(531, 15);
            this.logOutUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutUserButton.Name = "logOutUserButton";
            this.logOutUserButton.Size = new System.Drawing.Size(102, 27);
            this.logOutUserButton.TabIndex = 4;
            this.logOutUserButton.Text = "Log out";
            this.logOutUserButton.UseVisualStyleBackColor = false;
            this.logOutUserButton.Click += new System.EventHandler(this.logOutUserButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(423, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Students";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(316, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Organisations";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Edition";
            // 
            // education
            // 
            this.education.AutoSize = true;
            this.education.BackColor = System.Drawing.Color.Transparent;
            this.education.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.education.Location = new System.Drawing.Point(28, 10);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(132, 30);
            this.education.TabIndex = 0;
            this.education.Text = "Education+";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Transparent;
            this.filterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterButton.BackgroundImage")));
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterButton.Location = new System.Drawing.Point(78, 4);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(29, 26);
            this.filterButton.TabIndex = 5;
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftPanel.BackgroundImage")));
            this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftPanel.Controls.Add(this.filterButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 60);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(113, 352);
            this.leftPanel.TabIndex = 1;
            // 
            // fillPanel
            // 
            this.fillPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillPanel.BackgroundImage")));
            this.fillPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(113, 60);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(793, 352);
            this.fillPanel.TabIndex = 2;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 412);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headPanel;
        private Button icon;
        private Label email;
        private Label username;
        private Button settingsButton;
        private Button filterButton;
        private Button logOutUserButton;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label education;
        private Panel leftPanel;
        private Panel fillPanel;
    }
}