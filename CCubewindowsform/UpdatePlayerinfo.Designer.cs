namespace CCubewindowsform
{
    partial class UpdatePlayerinfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optionlb = new System.Windows.Forms.Label();
            this.optiontb = new System.Windows.Forms.TextBox();
            this.deleteplayerbtn = new System.Windows.Forms.Button();
            this.optioncb = new System.Windows.Forms.ComboBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.cnictb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optionlb);
            this.groupBox1.Controls.Add(this.optiontb);
            this.groupBox1.Location = new System.Drawing.Point(281, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Information";
            // 
            // optionlb
            // 
            this.optionlb.AutoSize = true;
            this.optionlb.Location = new System.Drawing.Point(19, 38);
            this.optionlb.Name = "optionlb";
            this.optionlb.Size = new System.Drawing.Size(0, 13);
            this.optionlb.TabIndex = 1;
            // 
            // optiontb
            // 
            this.optiontb.Location = new System.Drawing.Point(88, 35);
            this.optiontb.Name = "optiontb";
            this.optiontb.Size = new System.Drawing.Size(92, 20);
            this.optiontb.TabIndex = 0;
            // 
            // deleteplayerbtn
            // 
            this.deleteplayerbtn.Location = new System.Drawing.Point(395, 312);
            this.deleteplayerbtn.Name = "deleteplayerbtn";
            this.deleteplayerbtn.Size = new System.Drawing.Size(75, 23);
            this.deleteplayerbtn.TabIndex = 6;
            this.deleteplayerbtn.Text = "Update";
            this.deleteplayerbtn.UseVisualStyleBackColor = true;
            this.deleteplayerbtn.Click += new System.EventHandler(this.deleteplayerbtn_Click);
            // 
            // optioncb
            // 
            this.optioncb.FormattingEnabled = true;
            this.optioncb.Items.AddRange(new object[] {
            "CNIC",
            "NAME"});
            this.optioncb.Location = new System.Drawing.Point(85, 84);
            this.optioncb.Name = "optioncb";
            this.optioncb.Size = new System.Drawing.Size(121, 21);
            this.optioncb.TabIndex = 5;
            this.optioncb.SelectedIndexChanged += new System.EventHandler(this.optioncb_SelectedIndexChanged);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(381, 199);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 20);
            this.nametb.TabIndex = 2;
            // 
            // cnictb
            // 
            this.cnictb.Location = new System.Drawing.Point(381, 243);
            this.cnictb.Name = "cnictb";
            this.cnictb.Size = new System.Drawing.Size(100, 20);
            this.cnictb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cnic";
            // 
            // UpdatePlayerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnictb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteplayerbtn);
            this.Controls.Add(this.optioncb);
            this.Name = "UpdatePlayerinfo";
            this.Text = "UpdatePlayerinfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label optionlb;
        private System.Windows.Forms.TextBox optiontb;
        private System.Windows.Forms.Button deleteplayerbtn;
        private System.Windows.Forms.ComboBox optioncb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox cnictb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}