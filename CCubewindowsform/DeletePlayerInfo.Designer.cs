namespace CCubewindowsform
{
    partial class DeletePlayerInfo
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
            this.optioncb = new System.Windows.Forms.ComboBox();
            this.deleteplayerbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optiontb = new System.Windows.Forms.TextBox();
            this.optionlb = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optioncb
            // 
            this.optioncb.FormattingEnabled = true;
            this.optioncb.Items.AddRange(new object[] {
            "CNIC",
            "NAME"});
            this.optioncb.Location = new System.Drawing.Point(64, 79);
            this.optioncb.Name = "optioncb";
            this.optioncb.Size = new System.Drawing.Size(121, 21);
            this.optioncb.TabIndex = 0;
            this.optioncb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteplayerbtn
            // 
            this.deleteplayerbtn.Location = new System.Drawing.Point(85, 139);
            this.deleteplayerbtn.Name = "deleteplayerbtn";
            this.deleteplayerbtn.Size = new System.Drawing.Size(75, 23);
            this.deleteplayerbtn.TabIndex = 2;
            this.deleteplayerbtn.Text = "Delete";
            this.deleteplayerbtn.UseVisualStyleBackColor = true;
            this.deleteplayerbtn.Click += new System.EventHandler(this.deleteplayerbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optionlb);
            this.groupBox1.Controls.Add(this.optiontb);
            this.groupBox1.Location = new System.Drawing.Point(260, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Information";
            // 
            // optiontb
            // 
            this.optiontb.Location = new System.Drawing.Point(88, 35);
            this.optiontb.Name = "optiontb";
            this.optiontb.Size = new System.Drawing.Size(92, 20);
            this.optiontb.TabIndex = 0;
            // 
            // optionlb
            // 
            this.optionlb.AutoSize = true;
            this.optionlb.Location = new System.Drawing.Point(19, 38);
            this.optionlb.Name = "optionlb";
            this.optionlb.Size = new System.Drawing.Size(0, 13);
            this.optionlb.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(365, 179);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // DeletePlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteplayerbtn);
            this.Controls.Add(this.optioncb);
            this.Name = "DeletePlayerInfo";
            this.Text = "DeletePlayerInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox optioncb;
        private System.Windows.Forms.Button deleteplayerbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label optionlb;
        private System.Windows.Forms.TextBox optiontb;
        private System.Windows.Forms.Button exitbtn;
    }
}