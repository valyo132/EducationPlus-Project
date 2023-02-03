namespace EducationPLus
{
    partial class TypeOfRegistration
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
            this.userButton = new System.Windows.Forms.Button();
            this.NGObutton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(90, 99);
            this.userButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(136, 35);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // NGObutton
            // 
            this.NGObutton.Location = new System.Drawing.Point(359, 99);
            this.NGObutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NGObutton.Name = "NGObutton";
            this.NGObutton.Size = new System.Drawing.Size(136, 35);
            this.NGObutton.TabIndex = 3;
            this.NGObutton.Text = "NGO/Business";
            this.NGObutton.UseVisualStyleBackColor = true;
            this.NGObutton.Click += new System.EventHandler(this.NGObutton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(-2, -1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(73, 28);
            this.goBackButton.TabIndex = 4;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // TypeOfRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 268);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.NGObutton);
            this.Controls.Add(this.userButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TypeOfRegistration";
            this.Text = "TypeOfRegistration";
            this.ResumeLayout(false);

        }

        #endregion

        private Button userButton;
        private Button NGObutton;
        private Button goBackButton;
    }
}