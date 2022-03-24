namespace CCubewindowsform
{
    partial class _1PersonGame
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
            this.player1gb = new System.Windows.Forms.GroupBox();
            this.p1nametb = new System.Windows.Forms.TextBox();
            this.Cnic = new System.Windows.Forms.Label();
            this.p1cnictb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startgamebtn = new System.Windows.Forms.Button();
            this.player1gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1gb
            // 
            this.player1gb.Controls.Add(this.p1nametb);
            this.player1gb.Controls.Add(this.Cnic);
            this.player1gb.Controls.Add(this.p1cnictb);
            this.player1gb.Controls.Add(this.label1);
            this.player1gb.Location = new System.Drawing.Point(52, 44);
            this.player1gb.Name = "player1gb";
            this.player1gb.Size = new System.Drawing.Size(332, 100);
            this.player1gb.TabIndex = 5;
            this.player1gb.TabStop = false;
            this.player1gb.Text = "Player 1 ";
            // 
            // p1nametb
            // 
            this.p1nametb.Location = new System.Drawing.Point(198, 19);
            this.p1nametb.Name = "p1nametb";
            this.p1nametb.Size = new System.Drawing.Size(100, 20);
            this.p1nametb.TabIndex = 0;
            // 
            // Cnic
            // 
            this.Cnic.AutoSize = true;
            this.Cnic.Location = new System.Drawing.Point(35, 61);
            this.Cnic.Name = "Cnic";
            this.Cnic.Size = new System.Drawing.Size(28, 13);
            this.Cnic.TabIndex = 3;
            this.Cnic.Text = "Cnic";
            // 
            // p1cnictb
            // 
            this.p1cnictb.Location = new System.Drawing.Point(198, 58);
            this.p1cnictb.Name = "p1cnictb";
            this.p1cnictb.Size = new System.Drawing.Size(100, 20);
            this.p1cnictb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // startgamebtn
            // 
            this.startgamebtn.Location = new System.Drawing.Point(183, 191);
            this.startgamebtn.Name = "startgamebtn";
            this.startgamebtn.Size = new System.Drawing.Size(75, 23);
            this.startgamebtn.TabIndex = 7;
            this.startgamebtn.Text = "Start Game";
            this.startgamebtn.UseVisualStyleBackColor = true;
            this.startgamebtn.Click += new System.EventHandler(this.startgamebtn_Click);
            // 
            // _1PersonGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 333);
            this.Controls.Add(this.startgamebtn);
            this.Controls.Add(this.player1gb);
            this.Name = "_1PersonGame";
            this.Text = "_1PersonGame";
            this.player1gb.ResumeLayout(false);
            this.player1gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox player1gb;
        private System.Windows.Forms.TextBox p1nametb;
        private System.Windows.Forms.Label Cnic;
        private System.Windows.Forms.TextBox p1cnictb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startgamebtn;
    }
}