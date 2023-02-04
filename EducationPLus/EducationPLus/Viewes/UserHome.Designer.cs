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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.education = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.icon);
            this.headPanel.Controls.Add(this.email);
            this.headPanel.Controls.Add(this.username);
            this.headPanel.Controls.Add(this.settingsButton);
            this.headPanel.Controls.Add(this.filterButton);
            this.headPanel.Controls.Add(this.button3);
            this.headPanel.Controls.Add(this.button2);
            this.headPanel.Controls.Add(this.button1);
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Controls.Add(this.education);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1036, 80);
            this.headPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 80);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(129, 470);
            this.leftPanel.TabIndex = 1;
            // 
            // fillPanel
            // 
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(129, 80);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(907, 470);
            this.fillPanel.TabIndex = 2;
            // 
            // education
            // 
            this.education.AutoSize = true;
            this.education.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.education.Location = new System.Drawing.Point(32, 14);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(167, 38);
            this.education.TabIndex = 0;
            this.education.Text = "Education+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Edition";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Organisations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Students";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "About Us";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Transparent;
            this.filterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterButton.BackgroundImage")));
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterButton.Location = new System.Drawing.Point(310, 35);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(31, 28);
            this.filterButton.TabIndex = 5;
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(995, 47);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(29, 25);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(829, 28);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 20);
            this.username.TabIndex = 7;
            this.username.Text = "username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(829, 51);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 8;
            this.email.Text = "email";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Location = new System.Drawing.Point(779, 25);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(44, 46);
            this.icon.TabIndex = 9;
            this.icon.UseVisualStyleBackColor = false;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 550);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headPanel;
        private Button icon;
        private Label email;
        private Label username;
        private Button settingsButton;
        private Button filterButton;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label education;
        private Panel leftPanel;
        private Panel fillPanel;
    }
}