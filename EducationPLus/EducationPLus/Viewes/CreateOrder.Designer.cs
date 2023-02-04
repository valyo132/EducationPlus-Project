namespace EducationPLus.Viewes
{
    partial class CreateOrder
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
            this.orderNameHolder = new System.Windows.Forms.TextBox();
            this.orderDescriptionHolder = new System.Windows.Forms.TextBox();
            this.orderOppHolder = new System.Windows.Forms.TextBox();
            this.orderPlaceHolder = new System.Windows.Forms.TextBox();
            this.startDateHolder = new System.Windows.Forms.TextBox();
            this.endDateHolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderNameHolder
            // 
            this.orderNameHolder.Location = new System.Drawing.Point(231, 23);
            this.orderNameHolder.Name = "orderNameHolder";
            this.orderNameHolder.PlaceholderText = "Name";
            this.orderNameHolder.Size = new System.Drawing.Size(324, 27);
            this.orderNameHolder.TabIndex = 0;
            // 
            // orderDescriptionHolder
            // 
            this.orderDescriptionHolder.Location = new System.Drawing.Point(40, 70);
            this.orderDescriptionHolder.Multiline = true;
            this.orderDescriptionHolder.Name = "orderDescriptionHolder";
            this.orderDescriptionHolder.PlaceholderText = "Description";
            this.orderDescriptionHolder.Size = new System.Drawing.Size(324, 160);
            this.orderDescriptionHolder.TabIndex = 1;
            // 
            // orderOppHolder
            // 
            this.orderOppHolder.Location = new System.Drawing.Point(417, 70);
            this.orderOppHolder.Multiline = true;
            this.orderOppHolder.Name = "orderOppHolder";
            this.orderOppHolder.PlaceholderText = "Opportunities";
            this.orderOppHolder.Size = new System.Drawing.Size(324, 160);
            this.orderOppHolder.TabIndex = 2;
            // 
            // orderPlaceHolder
            // 
            this.orderPlaceHolder.Location = new System.Drawing.Point(231, 318);
            this.orderPlaceHolder.Name = "orderPlaceHolder";
            this.orderPlaceHolder.PlaceholderText = "Place";
            this.orderPlaceHolder.Size = new System.Drawing.Size(324, 27);
            this.orderPlaceHolder.TabIndex = 3;
            // 
            // startDateHolder
            // 
            this.startDateHolder.Location = new System.Drawing.Point(40, 259);
            this.startDateHolder.Name = "startDateHolder";
            this.startDateHolder.PlaceholderText = "Start Date";
            this.startDateHolder.Size = new System.Drawing.Size(324, 27);
            this.startDateHolder.TabIndex = 4;
            // 
            // endDateHolder
            // 
            this.endDateHolder.Location = new System.Drawing.Point(417, 259);
            this.endDateHolder.Name = "endDateHolder";
            this.endDateHolder.PlaceholderText = "End Date";
            this.endDateHolder.Size = new System.Drawing.Size(324, 27);
            this.endDateHolder.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endDateHolder);
            this.Controls.Add(this.startDateHolder);
            this.Controls.Add(this.orderPlaceHolder);
            this.Controls.Add(this.orderOppHolder);
            this.Controls.Add(this.orderDescriptionHolder);
            this.Controls.Add(this.orderNameHolder);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox orderNameHolder;
        private TextBox orderDescriptionHolder;
        private TextBox orderOppHolder;
        private TextBox orderPlaceHolder;
        private TextBox startDateHolder;
        private TextBox endDateHolder;
        private Button button1;
    }
}