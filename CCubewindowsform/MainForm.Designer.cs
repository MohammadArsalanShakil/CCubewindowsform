namespace CCubewindowsform
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gamebtn = new System.Windows.Forms.Button();
            this.registerplayerbtn = new System.Windows.Forms.Button();
            this.searchplayerbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.updateplayerbtn = new System.Windows.Forms.Button();
            this.deleteplayerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to CCube";
            // 
            // gamebtn
            // 
            this.gamebtn.Location = new System.Drawing.Point(17, 213);
            this.gamebtn.Name = "gamebtn";
            this.gamebtn.Size = new System.Drawing.Size(90, 61);
            this.gamebtn.TabIndex = 1;
            this.gamebtn.Text = "Start Game";
            this.gamebtn.UseVisualStyleBackColor = true;
            this.gamebtn.Click += new System.EventHandler(this.gamebtn_Click);
            // 
            // registerplayerbtn
            // 
            this.registerplayerbtn.Location = new System.Drawing.Point(17, 121);
            this.registerplayerbtn.Name = "registerplayerbtn";
            this.registerplayerbtn.Size = new System.Drawing.Size(90, 61);
            this.registerplayerbtn.TabIndex = 2;
            this.registerplayerbtn.Text = "Register New Player";
            this.registerplayerbtn.UseVisualStyleBackColor = true;
            this.registerplayerbtn.Click += new System.EventHandler(this.registerplayerbtn_Click);
            // 
            // searchplayerbtn
            // 
            this.searchplayerbtn.Location = new System.Drawing.Point(125, 121);
            this.searchplayerbtn.Name = "searchplayerbtn";
            this.searchplayerbtn.Size = new System.Drawing.Size(90, 61);
            this.searchplayerbtn.TabIndex = 3;
            this.searchplayerbtn.Text = "Search Player Information";
            this.searchplayerbtn.UseVisualStyleBackColor = true;
            this.searchplayerbtn.Click += new System.EventHandler(this.searchplayerbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(381, 251);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit Application";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // updateplayerbtn
            // 
            this.updateplayerbtn.Location = new System.Drawing.Point(236, 121);
            this.updateplayerbtn.Name = "updateplayerbtn";
            this.updateplayerbtn.Size = new System.Drawing.Size(90, 61);
            this.updateplayerbtn.TabIndex = 5;
            this.updateplayerbtn.Text = "Update Player Information";
            this.updateplayerbtn.UseVisualStyleBackColor = true;
            this.updateplayerbtn.Click += new System.EventHandler(this.updateplayerbtn_Click);
            // 
            // deleteplayerbtn
            // 
            this.deleteplayerbtn.Location = new System.Drawing.Point(344, 121);
            this.deleteplayerbtn.Name = "deleteplayerbtn";
            this.deleteplayerbtn.Size = new System.Drawing.Size(90, 61);
            this.deleteplayerbtn.TabIndex = 6;
            this.deleteplayerbtn.Text = "Delete Player Information";
            this.deleteplayerbtn.UseVisualStyleBackColor = true;
            this.deleteplayerbtn.Click += new System.EventHandler(this.deleteplayerbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 322);
            this.Controls.Add(this.deleteplayerbtn);
            this.Controls.Add(this.updateplayerbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.searchplayerbtn);
            this.Controls.Add(this.registerplayerbtn);
            this.Controls.Add(this.gamebtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gamebtn;
        private System.Windows.Forms.Button registerplayerbtn;
        private System.Windows.Forms.Button searchplayerbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button updateplayerbtn;
        private System.Windows.Forms.Button deleteplayerbtn;
    }
}

