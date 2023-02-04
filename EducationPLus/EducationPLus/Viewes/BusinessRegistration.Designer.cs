namespace EducationPLus
{
    partial class BusinessRegistration
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
            this.nameHolder = new System.Windows.Forms.TextBox();
            this.desciptionHolder = new System.Windows.Forms.TextBox();
            this.emailHolder = new System.Windows.Forms.TextBox();
            this.eventPlaceHolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.passwordHolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameHolder
            // 
            this.nameHolder.Location = new System.Drawing.Point(56, 68);
            this.nameHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PlaceholderText = "Name";
            this.nameHolder.Size = new System.Drawing.Size(302, 27);
            this.nameHolder.TabIndex = 0;
            // 
            // desciptionHolder
            // 
            this.desciptionHolder.Location = new System.Drawing.Point(56, 234);
            this.desciptionHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desciptionHolder.Multiline = true;
            this.desciptionHolder.Name = "desciptionHolder";
            this.desciptionHolder.PlaceholderText = "Description";
            this.desciptionHolder.Size = new System.Drawing.Size(302, 136);
            this.desciptionHolder.TabIndex = 1;
            // 
            // emailHolder
            // 
            this.emailHolder.Location = new System.Drawing.Point(56, 132);
            this.emailHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailHolder.Name = "emailHolder";
            this.emailHolder.PlaceholderText = "Email";
            this.emailHolder.Size = new System.Drawing.Size(302, 27);
            this.emailHolder.TabIndex = 2;
            // 
            // eventPlaceHolder
            // 
            this.eventPlaceHolder.Location = new System.Drawing.Point(56, 399);
            this.eventPlaceHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventPlaceHolder.Name = "eventPlaceHolder";
            this.eventPlaceHolder.PlaceholderText = "Place";
            this.eventPlaceHolder.Size = new System.Drawing.Size(302, 27);
            this.eventPlaceHolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(0, -1);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(83, 37);
            this.goBackButton.TabIndex = 12;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // passwordHolder
            // 
            this.passwordHolder.Location = new System.Drawing.Point(56, 182);
            this.passwordHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordHolder.Name = "passwordHolder";
            this.passwordHolder.PlaceholderText = "password";
            this.passwordHolder.Size = new System.Drawing.Size(302, 27);
            this.passwordHolder.TabIndex = 13;
            // 
            // BusinessRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 600);
            this.Controls.Add(this.passwordHolder);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventPlaceHolder);
            this.Controls.Add(this.emailHolder);
            this.Controls.Add(this.desciptionHolder);
            this.Controls.Add(this.nameHolder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BusinessRegistration";
            this.Text = "BusinessRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameHolder;
        private TextBox desciptionHolder;
        private TextBox emailHolder;
        private TextBox eventPlaceHolder;
        private Label label1;
        private Button button1;
        private Button goBackButton;
        private TextBox passwordHolder;
    }
}