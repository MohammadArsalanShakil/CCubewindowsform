namespace CCubewindowsform
{
    partial class _2PersonGame
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
            this.p1nametb = new System.Windows.Forms.TextBox();
            this.p1cnictb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cnic = new System.Windows.Forms.Label();
            this.player1gb = new System.Windows.Forms.GroupBox();
            this.player2gb = new System.Windows.Forms.GroupBox();
            this.p2nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p2cnictb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startgamebtn = new System.Windows.Forms.Button();
            this.player1gb.SuspendLayout();
            this.player2gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1nametb
            // 
            this.p1nametb.Location = new System.Drawing.Point(198, 19);
            this.p1nametb.Name = "p1nametb";
            this.p1nametb.Size = new System.Drawing.Size(100, 20);
            this.p1nametb.TabIndex = 0;
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
            // Cnic
            // 
            this.Cnic.AutoSize = true;
            this.Cnic.Location = new System.Drawing.Point(35, 61);
            this.Cnic.Name = "Cnic";
            this.Cnic.Size = new System.Drawing.Size(28, 13);
            this.Cnic.TabIndex = 3;
            this.Cnic.Text = "Cnic";
            // 
            // player1gb
            // 
            this.player1gb.Controls.Add(this.p1nametb);
            this.player1gb.Controls.Add(this.Cnic);
            this.player1gb.Controls.Add(this.p1cnictb);
            this.player1gb.Controls.Add(this.label1);
            this.player1gb.Location = new System.Drawing.Point(115, 36);
            this.player1gb.Name = "player1gb";
            this.player1gb.Size = new System.Drawing.Size(332, 100);
            this.player1gb.TabIndex = 4;
            this.player1gb.TabStop = false;
            this.player1gb.Text = "Player 1 ";
            // 
            // player2gb
            // 
            this.player2gb.Controls.Add(this.p2nametb);
            this.player2gb.Controls.Add(this.label2);
            this.player2gb.Controls.Add(this.p2cnictb);
            this.player2gb.Controls.Add(this.label3);
            this.player2gb.Location = new System.Drawing.Point(115, 165);
            this.player2gb.Name = "player2gb";
            this.player2gb.Size = new System.Drawing.Size(332, 100);
            this.player2gb.TabIndex = 5;
            this.player2gb.TabStop = false;
            this.player2gb.Text = "Player 2";
            // 
            // p2nametb
            // 
            this.p2nametb.Location = new System.Drawing.Point(198, 19);
            this.p2nametb.Name = "p2nametb";
            this.p2nametb.Size = new System.Drawing.Size(100, 20);
            this.p2nametb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cnic";
            // 
            // p2cnictb
            // 
            this.p2cnictb.Location = new System.Drawing.Point(198, 58);
            this.p2cnictb.Name = "p2cnictb";
            this.p2cnictb.Size = new System.Drawing.Size(100, 20);
            this.p2cnictb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // startgamebtn
            // 
            this.startgamebtn.Location = new System.Drawing.Point(243, 296);
            this.startgamebtn.Name = "startgamebtn";
            this.startgamebtn.Size = new System.Drawing.Size(75, 23);
            this.startgamebtn.TabIndex = 6;
            this.startgamebtn.Text = "Start Game";
            this.startgamebtn.UseVisualStyleBackColor = true;
            this.startgamebtn.Click += new System.EventHandler(this.startgamebtn_Click);
            // 
            // _2PersonGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 376);
            this.Controls.Add(this.startgamebtn);
            this.Controls.Add(this.player2gb);
            this.Controls.Add(this.player1gb);
            this.Name = "_2PersonGame";
            this.Text = "_2PersonGame";
            this.player1gb.ResumeLayout(false);
            this.player1gb.PerformLayout();
            this.player2gb.ResumeLayout(false);
            this.player2gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox p1nametb;
        private System.Windows.Forms.TextBox p1cnictb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cnic;
        private System.Windows.Forms.GroupBox player1gb;
        private System.Windows.Forms.GroupBox player2gb;
        private System.Windows.Forms.TextBox p2nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p2cnictb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startgamebtn;
    }
}