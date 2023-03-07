namespace App_Users
{
    partial class frmAppUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnRecentlyViewed = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.ucUserProfile1 = new App_Users.ucUserProfile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnHomePage);
            this.panel1.Controls.Add(this.btnRecentlyViewed);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 542);
            this.panel1.TabIndex = 0;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHomePage.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(12, 49);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(175, 52);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "Home";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRecentlyViewed
            // 
            this.btnRecentlyViewed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecentlyViewed.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentlyViewed.Location = new System.Drawing.Point(12, 229);
            this.btnRecentlyViewed.Name = "btnRecentlyViewed";
            this.btnRecentlyViewed.Size = new System.Drawing.Size(175, 52);
            this.btnRecentlyViewed.TabIndex = 2;
            this.btnRecentlyViewed.Text = "Recent";
            this.btnRecentlyViewed.UseVisualStyleBackColor = false;
            this.btnRecentlyViewed.Click += new System.EventHandler(this.btnRecentlyViewed_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(12, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(175, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(587, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 444);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(587, 491);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(121, 39);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(861, 491);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 39);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(206, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(356, 29);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(213, 30);
            this.textSearch.TabIndex = 5;
            // 
            // ucUserProfile1
            // 
            this.ucUserProfile1.AutoSize = true;
            this.ucUserProfile1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucUserProfile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucUserProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserProfile1.Location = new System.Drawing.Point(250, 0);
            this.ucUserProfile1.Name = "ucUserProfile1";
            this.ucUserProfile1.Size = new System.Drawing.Size(1015, 678);
            this.ucUserProfile1.TabIndex = 1;
            this.ucUserProfile1.Load += new System.EventHandler(this.ucUserProfile1_Load);
            // 
            // frmAppUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1012, 542);
            this.Controls.Add(this.ucUserProfile1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textSearch);
            this.Name = "frmAppUsers";
            this.Text = "App Users";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private ucUserProfile ucUserProfile1;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnRecentlyViewed;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
    }
}

