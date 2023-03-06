namespace App_Users
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem(new string[] {
            "ID"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem(new string[] {
            "First Name"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem(new string[] {
            "Last Name"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem(new string[] {
            "Street Address"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem(new string[] {
            "City"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "State"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem(new string[] {
            "Country"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem(new string[] {
            "Zip Code"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem(new string[] {
            "Email"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem(new string[] {
            "Date Of Birth"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem(new string[] {
            "Phone Number"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.listView1 = new System.Windows.Forms.ListView();
            this.textID = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.textDOB = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55});
            this.listView1.Location = new System.Drawing.Point(48, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 411);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(185, 56);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(175, 24);
            this.textID.TabIndex = 1;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(185, 162);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textAddress.Size = new System.Drawing.Size(175, 22);
            this.textAddress.TabIndex = 2;
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(185, 127);
            this.textLastName.Name = "textLastName";
            this.textLastName.ReadOnly = true;
            this.textLastName.Size = new System.Drawing.Size(175, 24);
            this.textLastName.TabIndex = 3;
            // 
            // textFirstname
            // 
            this.textFirstname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstname.Location = new System.Drawing.Point(185, 91);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.ReadOnly = true;
            this.textFirstname.Size = new System.Drawing.Size(175, 24);
            this.textFirstname.TabIndex = 4;
            // 
            // textState
            // 
            this.textState.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textState.Location = new System.Drawing.Point(185, 231);
            this.textState.Name = "textState";
            this.textState.ReadOnly = true;
            this.textState.Size = new System.Drawing.Size(175, 24);
            this.textState.TabIndex = 5;
            // 
            // textCity
            // 
            this.textCity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCity.Location = new System.Drawing.Point(185, 195);
            this.textCity.Name = "textCity";
            this.textCity.ReadOnly = true;
            this.textCity.Size = new System.Drawing.Size(175, 24);
            this.textCity.TabIndex = 6;
            // 
            // textCountry
            // 
            this.textCountry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCountry.Location = new System.Drawing.Point(185, 268);
            this.textCountry.Name = "textCountry";
            this.textCountry.ReadOnly = true;
            this.textCountry.Size = new System.Drawing.Size(175, 24);
            this.textCountry.TabIndex = 7;
            // 
            // textDOB
            // 
            this.textDOB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDOB.Location = new System.Drawing.Point(185, 377);
            this.textDOB.Name = "textDOB";
            this.textDOB.ReadOnly = true;
            this.textDOB.Size = new System.Drawing.Size(175, 24);
            this.textDOB.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(185, 344);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(175, 24);
            this.textEmail.TabIndex = 9;
            // 
            // textZipCode
            // 
            this.textZipCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textZipCode.Location = new System.Drawing.Point(185, 305);
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.ReadOnly = true;
            this.textZipCode.Size = new System.Drawing.Size(175, 24);
            this.textZipCode.TabIndex = 10;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(185, 412);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.ReadOnly = true;
            this.textPhoneNumber.Size = new System.Drawing.Size(175, 24);
            this.textPhoneNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "00:00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(495, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textDOB);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textDOB;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textZipCode;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}