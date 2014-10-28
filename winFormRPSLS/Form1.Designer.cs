namespace winFormRPSLS
{
    partial class Form1
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
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lizardBtn = new System.Windows.Forms.Button();
            this.spockBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.Location = new System.Drawing.Point(21, 19);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(75, 23);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Location = new System.Drawing.Point(21, 48);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(75, 23);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Location = new System.Drawing.Point(21, 77);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(75, 23);
            this.scissorsBtn.TabIndex = 2;
            this.scissorsBtn.Text = "Scissors";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Rock Paper Scissors Lizard Spock!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spockBtn);
            this.groupBox1.Controls.Add(this.lizardBtn);
            this.groupBox1.Controls.Add(this.rockBtn);
            this.groupBox1.Controls.Add(this.paperBtn);
            this.groupBox1.Controls.Add(this.scissorsBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click one to play:";
            // 
            // lizardBtn
            // 
            this.lizardBtn.Location = new System.Drawing.Point(21, 106);
            this.lizardBtn.Name = "lizardBtn";
            this.lizardBtn.Size = new System.Drawing.Size(75, 23);
            this.lizardBtn.TabIndex = 3;
            this.lizardBtn.Text = "Lizard";
            this.lizardBtn.UseVisualStyleBackColor = true;
            this.lizardBtn.Click += new System.EventHandler(this.lizardBtn_Click);
            // 
            // spockBtn
            // 
            this.spockBtn.Location = new System.Drawing.Point(21, 135);
            this.spockBtn.Name = "spockBtn";
            this.spockBtn.Size = new System.Drawing.Size(75, 23);
            this.spockBtn.TabIndex = 4;
            this.spockBtn.Text = "Spock";
            this.spockBtn.UseVisualStyleBackColor = true;
            this.spockBtn.Click += new System.EventHandler(this.spockBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(197, 227);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button spockBtn;
        private System.Windows.Forms.Button lizardBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

