namespace EducationPLus
{
    partial class UserRegister
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
            this.firstNameHolder = new System.Windows.Forms.TextBox();
            this.lastNameHolder = new System.Windows.Forms.TextBox();
            this.passwordHolder = new System.Windows.Forms.TextBox();
            this.ageHolder = new System.Windows.Forms.TextBox();
            this.descriptionHolder = new System.Windows.Forms.TextBox();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.emailHolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameHolder
            // 
            this.firstNameHolder.Location = new System.Drawing.Point(91, 49);
            this.firstNameHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameHolder.Name = "firstNameHolder";
            this.firstNameHolder.PlaceholderText = "First name";
            this.firstNameHolder.Size = new System.Drawing.Size(254, 23);
            this.firstNameHolder.TabIndex = 0;
            // 
            // lastNameHolder
            // 
            this.lastNameHolder.Location = new System.Drawing.Point(91, 95);
            this.lastNameHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameHolder.Name = "lastNameHolder";
            this.lastNameHolder.PlaceholderText = "Last name";
            this.lastNameHolder.Size = new System.Drawing.Size(254, 23);
            this.lastNameHolder.TabIndex = 1;
            // 
            // passwordHolder
            // 
            this.passwordHolder.Location = new System.Drawing.Point(91, 178);
            this.passwordHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordHolder.Name = "passwordHolder";
            this.passwordHolder.PlaceholderText = "Password";
            this.passwordHolder.Size = new System.Drawing.Size(254, 23);
            this.passwordHolder.TabIndex = 2;
            // 
            // ageHolder
            // 
            this.ageHolder.Location = new System.Drawing.Point(91, 230);
            this.ageHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageHolder.Name = "ageHolder";
            this.ageHolder.PlaceholderText = "Age";
            this.ageHolder.Size = new System.Drawing.Size(61, 23);
            this.ageHolder.TabIndex = 3;
            // 
            // descriptionHolder
            // 
            this.descriptionHolder.Location = new System.Drawing.Point(38, 269);
            this.descriptionHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionHolder.Multiline = true;
            this.descriptionHolder.Name = "descriptionHolder";
            this.descriptionHolder.PlaceholderText = "Description";
            this.descriptionHolder.Size = new System.Drawing.Size(365, 88);
            this.descriptionHolder.TabIndex = 4;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(181, 232);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(51, 19);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(276, 230);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(63, 19);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // emailHolder
            // 
            this.emailHolder.Location = new System.Drawing.Point(91, 135);
            this.emailHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailHolder.Name = "emailHolder";
            this.emailHolder.PlaceholderText = "Email";
            this.emailHolder.Size = new System.Drawing.Size(254, 23);
            this.emailHolder.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(0, -1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(73, 28);
            this.goBackButton.TabIndex = 10;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 440);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailHolder);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.descriptionHolder);
            this.Controls.Add(this.ageHolder);
            this.Controls.Add(this.passwordHolder);
            this.Controls.Add(this.lastNameHolder);
            this.Controls.Add(this.firstNameHolder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNameHolder;
        private TextBox lastNameHolder;
        private TextBox passwordHolder;
        private TextBox ageHolder;
        private TextBox descriptionHolder;
        private RadioButton maleRadio;
        private RadioButton femaleRadio;
        private TextBox emailHolder;
        private Button button1;
        private Label label1;
        private Button goBackButton;
    }
}