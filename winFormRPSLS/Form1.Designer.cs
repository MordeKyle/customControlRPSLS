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
            this.spockBtn = new System.Windows.Forms.Button();
            this.lizardBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userChoiceLbl = new System.Windows.Forms.Label();
            this.computerChoiceLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.winsLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.losesLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.drawsLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
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
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(257, 264);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "You Chose:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer Chose:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result:";
            // 
            // userChoiceLbl
            // 
            this.userChoiceLbl.AutoSize = true;
            this.userChoiceLbl.Location = new System.Drawing.Point(109, 210);
            this.userChoiceLbl.Name = "userChoiceLbl";
            this.userChoiceLbl.Size = new System.Drawing.Size(74, 13);
            this.userChoiceLbl.TabIndex = 9;
            this.userChoiceLbl.Text = "userChoiceLbl";
            // 
            // computerChoiceLbl
            // 
            this.computerChoiceLbl.AutoSize = true;
            this.computerChoiceLbl.Location = new System.Drawing.Point(109, 228);
            this.computerChoiceLbl.Name = "computerChoiceLbl";
            this.computerChoiceLbl.Size = new System.Drawing.Size(98, 13);
            this.computerChoiceLbl.TabIndex = 10;
            this.computerChoiceLbl.Text = "computerChoiceLbl";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(109, 246);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(46, 13);
            this.resultLbl.TabIndex = 11;
            this.resultLbl.Text = "resultLbl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wins:";
            // 
            // winsLbl
            // 
            this.winsLbl.AutoSize = true;
            this.winsLbl.Location = new System.Drawing.Point(203, 58);
            this.winsLbl.Name = "winsLbl";
            this.winsLbl.Size = new System.Drawing.Size(42, 13);
            this.winsLbl.TabIndex = 13;
            this.winsLbl.Text = "winsLbl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loses:";
            // 
            // losesLbl
            // 
            this.losesLbl.AutoSize = true;
            this.losesLbl.Location = new System.Drawing.Point(203, 87);
            this.losesLbl.Name = "losesLbl";
            this.losesLbl.Size = new System.Drawing.Size(45, 13);
            this.losesLbl.TabIndex = 15;
            this.losesLbl.Text = "losesLbl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Draws:";
            // 
            // drawsLbl
            // 
            this.drawsLbl.AutoSize = true;
            this.drawsLbl.Location = new System.Drawing.Point(203, 116);
            this.drawsLbl.Name = "drawsLbl";
            this.drawsLbl.Size = new System.Drawing.Size(49, 13);
            this.drawsLbl.TabIndex = 17;
            this.drawsLbl.Text = "drawsLbl";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(166, 264);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 23);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear Results";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 299);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.drawsLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.losesLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.winsLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.computerChoiceLbl);
            this.Controls.Add(this.userChoiceLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userChoiceLbl;
        private System.Windows.Forms.Label computerChoiceLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label winsLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label losesLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label drawsLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}

