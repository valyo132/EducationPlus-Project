namespace EducationPLus.Viewes
{
    partial class Ad
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
            this.adNameHolder = new System.Windows.Forms.Label();
            this.descriptionHolder = new System.Windows.Forms.Label();
            this.startDateHolder = new System.Windows.Forms.Label();
            this.endDateHolder = new System.Windows.Forms.Label();
            this.adPlaceHolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adNameHolder
            // 
            this.adNameHolder.AutoSize = true;
            this.adNameHolder.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.adNameHolder.Location = new System.Drawing.Point(280, 9);
            this.adNameHolder.Name = "adNameHolder";
            this.adNameHolder.Size = new System.Drawing.Size(141, 50);
            this.adNameHolder.TabIndex = 0;
            this.adNameHolder.Text = "header";
            // 
            // descriptionHolder
            // 
            this.descriptionHolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionHolder.Location = new System.Drawing.Point(102, 75);
            this.descriptionHolder.Name = "descriptionHolder";
            this.descriptionHolder.Size = new System.Drawing.Size(497, 181);
            this.descriptionHolder.TabIndex = 1;
            // 
            // startDateHolder
            // 
            this.startDateHolder.AutoSize = true;
            this.startDateHolder.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateHolder.Location = new System.Drawing.Point(102, 274);
            this.startDateHolder.Name = "startDateHolder";
            this.startDateHolder.Size = new System.Drawing.Size(145, 38);
            this.startDateHolder.TabIndex = 2;
            this.startDateHolder.Text = "Start Date:";
            // 
            // endDateHolder
            // 
            this.endDateHolder.AutoSize = true;
            this.endDateHolder.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDateHolder.Location = new System.Drawing.Point(102, 331);
            this.endDateHolder.Name = "endDateHolder";
            this.endDateHolder.Size = new System.Drawing.Size(135, 38);
            this.endDateHolder.TabIndex = 3;
            this.endDateHolder.Text = "End Date:";
            // 
            // adPlaceHolder
            // 
            this.adPlaceHolder.AutoSize = true;
            this.adPlaceHolder.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adPlaceHolder.Location = new System.Drawing.Point(102, 388);
            this.adPlaceHolder.Name = "adPlaceHolder";
            this.adPlaceHolder.Size = new System.Drawing.Size(88, 38);
            this.adPlaceHolder.TabIndex = 4;
            this.adPlaceHolder.Text = "Place:";
            // 
            // Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 535);
            this.Controls.Add(this.adPlaceHolder);
            this.Controls.Add(this.endDateHolder);
            this.Controls.Add(this.startDateHolder);
            this.Controls.Add(this.descriptionHolder);
            this.Controls.Add(this.adNameHolder);
            this.Name = "Ad";
            this.Text = "Ad";
            this.Load += new System.EventHandler(this.Ad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label adNameHolder;
        private Label descriptionHolder;
        private Label startDateHolder;
        private Label endDateHolder;
        private Label adPlaceHolder;
    }
}