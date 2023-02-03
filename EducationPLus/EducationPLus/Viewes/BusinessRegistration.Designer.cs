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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailHolder = new System.Windows.Forms.TextBox();
            this.eventPlaceHolder = new System.Windows.Forms.TextBox();
            this.dateHolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameHolder
            // 
            this.nameHolder.Location = new System.Drawing.Point(50, 55);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PlaceholderText = "Name";
            this.nameHolder.Size = new System.Drawing.Size(265, 23);
            this.nameHolder.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Description";
            this.textBox1.Size = new System.Drawing.Size(265, 103);
            this.textBox1.TabIndex = 1;
            // 
            // emailHolder
            // 
            this.emailHolder.Location = new System.Drawing.Point(50, 103);
            this.emailHolder.Name = "emailHolder";
            this.emailHolder.PlaceholderText = "Email";
            this.emailHolder.Size = new System.Drawing.Size(265, 23);
            this.emailHolder.TabIndex = 2;
            // 
            // eventPlaceHolder
            // 
            this.eventPlaceHolder.Location = new System.Drawing.Point(50, 273);
            this.eventPlaceHolder.Name = "eventPlaceHolder";
            this.eventPlaceHolder.PlaceholderText = "Place";
            this.eventPlaceHolder.Size = new System.Drawing.Size(265, 23);
            this.eventPlaceHolder.TabIndex = 3;
            // 
            // dateHolder
            // 
            this.dateHolder.Location = new System.Drawing.Point(50, 319);
            this.dateHolder.Name = "dateHolder";
            this.dateHolder.PlaceholderText = "Date";
            this.dateHolder.Size = new System.Drawing.Size(265, 23);
            this.dateHolder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(0, -1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(73, 28);
            this.goBackButton.TabIndex = 12;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // BusinessRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHolder);
            this.Controls.Add(this.eventPlaceHolder);
            this.Controls.Add(this.emailHolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameHolder);
            this.Name = "BusinessRegistration";
            this.Text = "BusinessRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameHolder;
        private TextBox textBox1;
        private TextBox emailHolder;
        private TextBox eventPlaceHolder;
        private TextBox dateHolder;
        private Label label1;
        private Button button1;
        private Button goBackButton;
    }
}