namespace App_Users
{
    partial class ucUserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHomePage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHomePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHomePage.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.Location = new System.Drawing.Point(12, 12);
            this.lblHomePage.Margin = new System.Windows.Forms.Padding(12, 0, 3, 12);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.lblHomePage.Size = new System.Drawing.Size(370, 95);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = "Home Page";
            this.lblHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblHomePage);
            this.Name = "ucUserProfile";
            this.Size = new System.Drawing.Size(661, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomePage;
    }
}
