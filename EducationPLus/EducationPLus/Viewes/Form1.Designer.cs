namespace EducationPLus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameHolder = new System.Windows.Forms.TextBox();
            this.passHolder = new System.Windows.Forms.TextBox();
            this.checkIfOrganisation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Education+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "SignUp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameHolder
            // 
            this.NameHolder.Location = new System.Drawing.Point(42, 143);
            this.NameHolder.Name = "NameHolder";
            this.NameHolder.PlaceholderText = "Username";
            this.NameHolder.Size = new System.Drawing.Size(268, 27);
            this.NameHolder.TabIndex = 3;
            // 
            // passHolder
            // 
            this.passHolder.Location = new System.Drawing.Point(42, 204);
            this.passHolder.Name = "passHolder";
            this.passHolder.PlaceholderText = "Password";
            this.passHolder.Size = new System.Drawing.Size(268, 27);
            this.passHolder.TabIndex = 4;
            // 
            // checkIfOrganisation
            // 
            this.checkIfOrganisation.AutoSize = true;
            this.checkIfOrganisation.Location = new System.Drawing.Point(42, 237);
            this.checkIfOrganisation.Name = "checkIfOrganisation";
            this.checkIfOrganisation.Size = new System.Drawing.Size(124, 24);
            this.checkIfOrganisation.TabIndex = 5;
            this.checkIfOrganisation.Text = "NGO/Business";
            this.checkIfOrganisation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 424);
            this.Controls.Add(this.checkIfOrganisation);
            this.Controls.Add(this.passHolder);
            this.Controls.Add(this.NameHolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox NameHolder;
        private TextBox passHolder;
        private CheckBox checkIfOrganisation;
    }
}