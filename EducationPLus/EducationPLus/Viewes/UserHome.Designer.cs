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
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.userIcon = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.organisationButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.events = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.accountSettings = new System.Windows.Forms.Label();
            this.settingWheelButton = new System.Windows.Forms.Button();
            this.funnelButton = new System.Windows.Forms.Button();
            this.shareEventButton = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Maroon;
            this.title.Location = new System.Drawing.Point(12, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(166, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Education+";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.subtitle.ForeColor = System.Drawing.Color.Maroon;
            this.subtitle.Location = new System.Drawing.Point(21, 57);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(119, 20);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "Student Edition";
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.headPanel.Controls.Add(this.funnelButton);
            this.headPanel.Controls.Add(this.settingWheelButton);
            this.headPanel.Controls.Add(this.accountSettings);
            this.headPanel.Controls.Add(this.email);
            this.headPanel.Controls.Add(this.name);
            this.headPanel.Controls.Add(this.userIcon);
            this.headPanel.Controls.Add(this.searchIcon);
            this.headPanel.Controls.Add(this.search);
            this.headPanel.Controls.Add(this.aboutUsButton);
            this.headPanel.Controls.Add(this.studentsButton);
            this.headPanel.Controls.Add(this.organisationButton);
            this.headPanel.Controls.Add(this.subtitle);
            this.headPanel.Controls.Add(this.title);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1013, 96);
            this.headPanel.TabIndex = 2;
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIcon.BackgroundImage")));
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.Location = new System.Drawing.Point(847, 20);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(47, 43);
            this.userIcon.TabIndex = 7;
            // 
            // searchIcon
            // 
            this.searchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchIcon.BackgroundImage")));
            this.searchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchIcon.Location = new System.Drawing.Point(171, 64);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(29, 29);
            this.searchIcon.TabIndex = 6;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.PeachPuff;
            this.search.ForeColor = System.Drawing.Color.Maroon;
            this.search.Location = new System.Drawing.Point(206, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(570, 23);
            this.search.TabIndex = 5;
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.BackColor = System.Drawing.Color.MistyRose;
            this.aboutUsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutUsButton.ForeColor = System.Drawing.Color.Firebrick;
            this.aboutUsButton.Location = new System.Drawing.Point(679, 20);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(129, 32);
            this.aboutUsButton.TabIndex = 4;
            this.aboutUsButton.Text = "About us";
            this.aboutUsButton.UseVisualStyleBackColor = false;
            // 
            // studentsButton
            // 
            this.studentsButton.BackColor = System.Drawing.Color.MistyRose;
            this.studentsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentsButton.ForeColor = System.Drawing.Color.Firebrick;
            this.studentsButton.Location = new System.Drawing.Point(528, 20);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(129, 32);
            this.studentsButton.TabIndex = 3;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = false;
            // 
            // organisationButton
            // 
            this.organisationButton.BackColor = System.Drawing.Color.MistyRose;
            this.organisationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.organisationButton.ForeColor = System.Drawing.Color.Firebrick;
            this.organisationButton.Location = new System.Drawing.Point(378, 20);
            this.organisationButton.Name = "organisationButton";
            this.organisationButton.Size = new System.Drawing.Size(129, 32);
            this.organisationButton.TabIndex = 2;
            this.organisationButton.Text = "Organisations";
            this.organisationButton.UseVisualStyleBackColor = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Tomato;
            this.leftPanel.Controls.Add(this.shareEventButton);
            this.leftPanel.Controls.Add(this.events);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 96);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(171, 466);
            this.leftPanel.TabIndex = 3;
            // 
            // events
            // 
            this.events.AutoSize = true;
            this.events.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.events.ForeColor = System.Drawing.Color.Maroon;
            this.events.Location = new System.Drawing.Point(35, 3);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(105, 32);
            this.events.TabIndex = 1;
            this.events.Text = "Events+";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Coral;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(847, 96);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(166, 466);
            this.rightPanel.TabIndex = 4;
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.MistyRose;
            this.fillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(171, 96);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(676, 466);
            this.fillPanel.TabIndex = 5;
            this.fillPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Maroon;
            this.name.Location = new System.Drawing.Point(900, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 20);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(900, 43);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 8;
            this.email.Text = "email";
            // 
            // accountSettings
            // 
            this.accountSettings.AutoSize = true;
            this.accountSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.accountSettings.ForeColor = System.Drawing.Color.Maroon;
            this.accountSettings.Location = new System.Drawing.Point(881, 68);
            this.accountSettings.Name = "accountSettings";
            this.accountSettings.Size = new System.Drawing.Size(120, 20);
            this.accountSettings.TabIndex = 10;
            this.accountSettings.Text = "Account Settings";
            // 
            // settingWheelButton
            // 
            this.settingWheelButton.BackColor = System.Drawing.Color.Transparent;
            this.settingWheelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingWheelButton.BackgroundImage")));
            this.settingWheelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingWheelButton.Location = new System.Drawing.Point(847, 65);
            this.settingWheelButton.Name = "settingWheelButton";
            this.settingWheelButton.Size = new System.Drawing.Size(28, 27);
            this.settingWheelButton.TabIndex = 11;
            this.settingWheelButton.UseVisualStyleBackColor = false;
            // 
            // funnelButton
            // 
            this.funnelButton.BackColor = System.Drawing.Color.Transparent;
            this.funnelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("funnelButton.BackgroundImage")));
            this.funnelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.funnelButton.Location = new System.Drawing.Point(782, 67);
            this.funnelButton.Name = "funnelButton";
            this.funnelButton.Size = new System.Drawing.Size(26, 25);
            this.funnelButton.TabIndex = 12;
            this.funnelButton.UseVisualStyleBackColor = false;
            // 
            // shareEventButton
            // 
            this.shareEventButton.BackColor = System.Drawing.Color.MistyRose;
            this.shareEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shareEventButton.ForeColor = System.Drawing.Color.Firebrick;
            this.shareEventButton.Location = new System.Drawing.Point(21, 422);
            this.shareEventButton.Name = "shareEventButton";
            this.shareEventButton.Size = new System.Drawing.Size(129, 32);
            this.shareEventButton.TabIndex = 3;
            this.shareEventButton.Text = "Share Event";
            this.shareEventButton.UseVisualStyleBackColor = false;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 562);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label title;
        private Label subtitle;
        private Panel headPanel;
        private Panel leftPanel;
        private Panel searchIcon;
        private TextBox search;
        private Button aboutUsButton;
        private Button studentsButton;
        private Button organisationButton;
        private Panel rightPanel;
        private Panel fillPanel;
        private Panel userIcon;
        private Label events;
        private Label email;
        private Label name;
        private Button settingWheelButton;
        private Label accountSettings;
        private Button funnelButton;
        private Button shareEventButton;
    }
}