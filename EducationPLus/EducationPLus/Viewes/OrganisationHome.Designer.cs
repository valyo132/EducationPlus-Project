namespace EducationPLus.Viewes
{
    partial class OrganisationHome
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
            this.organisationNameHolder = new System.Windows.Forms.Label();
            this.emailHolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // organisationNameHolder
            // 
            this.organisationNameHolder.AutoSize = true;
            this.organisationNameHolder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.organisationNameHolder.Location = new System.Drawing.Point(521, 9);
            this.organisationNameHolder.Name = "organisationNameHolder";
            this.organisationNameHolder.Size = new System.Drawing.Size(95, 41);
            this.organisationNameHolder.TabIndex = 0;
            this.organisationNameHolder.Text = "name";
            // 
            // emailHolder
            // 
            this.emailHolder.AutoSize = true;
            this.emailHolder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailHolder.Location = new System.Drawing.Point(546, 50);
            this.emailHolder.Name = "emailHolder";
            this.emailHolder.Size = new System.Drawing.Size(58, 31);
            this.emailHolder.TabIndex = 1;
            this.emailHolder.Text = "mail";
            // 
            // OrganisationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 594);
            this.Controls.Add(this.emailHolder);
            this.Controls.Add(this.organisationNameHolder);
            this.Name = "OrganisationHome";
            this.Text = "OrganisationHome";
            this.Load += new System.EventHandler(this.OrganisationHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label organisationNameHolder;
        private Label emailHolder;
    }
}