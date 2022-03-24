namespace CCubewindowsform
{
    partial class SearchPlayerInfo
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
            this.playerinfortb = new System.Windows.Forms.RichTextBox();
            this.optioncb = new System.Windows.Forms.ComboBox();
            this.inputGB = new System.Windows.Forms.GroupBox();
            this.optionlb = new System.Windows.Forms.Label();
            this.optiontb = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.inputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerinfortb
            // 
            this.playerinfortb.Location = new System.Drawing.Point(306, 12);
            this.playerinfortb.Name = "playerinfortb";
            this.playerinfortb.ReadOnly = true;
            this.playerinfortb.Size = new System.Drawing.Size(231, 402);
            this.playerinfortb.TabIndex = 0;
            this.playerinfortb.Text = "";
            // 
            // optioncb
            // 
            this.optioncb.FormattingEnabled = true;
            this.optioncb.Items.AddRange(new object[] {
            "Search All Players",
            "Seach By Name",
            "Search By CNIC"});
            this.optioncb.Location = new System.Drawing.Point(86, 12);
            this.optioncb.Name = "optioncb";
            this.optioncb.Size = new System.Drawing.Size(121, 21);
            this.optioncb.TabIndex = 1;
            this.optioncb.SelectedIndexChanged += new System.EventHandler(this.optioncb_SelectedIndexChanged);
            // 
            // inputGB
            // 
            this.inputGB.Controls.Add(this.searchbtn);
            this.inputGB.Controls.Add(this.optiontb);
            this.inputGB.Controls.Add(this.optionlb);
            this.inputGB.Location = new System.Drawing.Point(12, 61);
            this.inputGB.Name = "inputGB";
            this.inputGB.Size = new System.Drawing.Size(265, 167);
            this.inputGB.TabIndex = 2;
            this.inputGB.TabStop = false;
            this.inputGB.Text = "Enter Information";
            // 
            // optionlb
            // 
            this.optionlb.AutoSize = true;
            this.optionlb.Location = new System.Drawing.Point(28, 46);
            this.optionlb.Name = "optionlb";
            this.optionlb.Size = new System.Drawing.Size(35, 13);
            this.optionlb.TabIndex = 0;
            this.optionlb.Text = "label1";
            // 
            // optiontb
            // 
            this.optiontb.Location = new System.Drawing.Point(93, 43);
            this.optiontb.Name = "optiontb";
            this.optiontb.Size = new System.Drawing.Size(127, 20);
            this.optiontb.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(145, 103);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SearchPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 426);
            this.Controls.Add(this.inputGB);
            this.Controls.Add(this.optioncb);
            this.Controls.Add(this.playerinfortb);
            this.Name = "SearchPlayerInfo";
            this.Text = "SearchPlayerInfo";
            this.Load += new System.EventHandler(this.SearchPlayerInfo_Load);
            this.inputGB.ResumeLayout(false);
            this.inputGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox playerinfortb;
        private System.Windows.Forms.ComboBox optioncb;
        private System.Windows.Forms.GroupBox inputGB;
        private System.Windows.Forms.TextBox optiontb;
        private System.Windows.Forms.Label optionlb;
        private System.Windows.Forms.Button searchbtn;
    }
}