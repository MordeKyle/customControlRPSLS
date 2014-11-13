namespace winFormRPSLS
{
    partial class RPSLS_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPSLS_Form));
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spockBtn = new System.Windows.Forms.Button();
            this.lizardBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.rockBtn.Location = new System.Drawing.Point(27, 34);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(92, 35);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "&Rock";
            this.rockBtn.UseVisualStyleBackColor = false;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.paperBtn.Location = new System.Drawing.Point(27, 68);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(92, 35);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "&Paper";
            this.paperBtn.UseVisualStyleBackColor = false;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.scissorsBtn.Location = new System.Drawing.Point(27, 102);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(92, 35);
            this.scissorsBtn.TabIndex = 2;
            this.scissorsBtn.Text = "&Scissors";
            this.scissorsBtn.UseVisualStyleBackColor = false;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Rock Paper Scissors Lizard Spock!";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.spockBtn);
            this.groupBox1.Controls.Add(this.lizardBtn);
            this.groupBox1.Controls.Add(this.rockBtn);
            this.groupBox1.Controls.Add(this.paperBtn);
            this.groupBox1.Controls.Add(this.scissorsBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick your choice:";
            // 
            // spockBtn
            // 
            this.spockBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.spockBtn.Location = new System.Drawing.Point(27, 170);
            this.spockBtn.Name = "spockBtn";
            this.spockBtn.Size = new System.Drawing.Size(92, 35);
            this.spockBtn.TabIndex = 4;
            this.spockBtn.Text = "Spoc&k";
            this.spockBtn.UseVisualStyleBackColor = false;
            this.spockBtn.Click += new System.EventHandler(this.spockBtn_Click);
            // 
            // lizardBtn
            // 
            this.lizardBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.lizardBtn.Location = new System.Drawing.Point(27, 136);
            this.lizardBtn.Name = "lizardBtn";
            this.lizardBtn.Size = new System.Drawing.Size(92, 35);
            this.lizardBtn.TabIndex = 3;
            this.lizardBtn.Text = "&Lizard";
            this.lizardBtn.UseVisualStyleBackColor = false;
            this.lizardBtn.Click += new System.EventHandler(this.lizardBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(295, 236);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 37);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer Chose:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result:";
            // 
            // userChoiceLbl
            // 
            this.userChoiceLbl.AutoSize = true;
            this.userChoiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userChoiceLbl.Location = new System.Drawing.Point(123, 27);
            this.userChoiceLbl.Name = "userChoiceLbl";
            this.userChoiceLbl.Size = new System.Drawing.Size(86, 15);
            this.userChoiceLbl.TabIndex = 9;
            this.userChoiceLbl.Text = "userChoiceLbl";
            // 
            // computerChoiceLbl
            // 
            this.computerChoiceLbl.AutoSize = true;
            this.computerChoiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceLbl.Location = new System.Drawing.Point(123, 45);
            this.computerChoiceLbl.Name = "computerChoiceLbl";
            this.computerChoiceLbl.Size = new System.Drawing.Size(114, 15);
            this.computerChoiceLbl.TabIndex = 10;
            this.computerChoiceLbl.Text = "computerChoiceLbl";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(123, 63);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(63, 15);
            this.resultLbl.TabIndex = 11;
            this.resultLbl.Text = "resultLbl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wins:";
            // 
            // winsLbl
            // 
            this.winsLbl.AutoSize = true;
            this.winsLbl.Location = new System.Drawing.Point(104, 16);
            this.winsLbl.Name = "winsLbl";
            this.winsLbl.Size = new System.Drawing.Size(49, 15);
            this.winsLbl.TabIndex = 13;
            this.winsLbl.Text = "winsLbl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loses:";
            // 
            // losesLbl
            // 
            this.losesLbl.AutoSize = true;
            this.losesLbl.Location = new System.Drawing.Point(105, 37);
            this.losesLbl.Name = "losesLbl";
            this.losesLbl.Size = new System.Drawing.Size(53, 15);
            this.losesLbl.TabIndex = 15;
            this.losesLbl.Text = "losesLbl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Draws:";
            // 
            // drawsLbl
            // 
            this.drawsLbl.AutoSize = true;
            this.drawsLbl.Location = new System.Drawing.Point(105, 58);
            this.drawsLbl.Name = "drawsLbl";
            this.drawsLbl.Size = new System.Drawing.Size(57, 15);
            this.drawsLbl.TabIndex = 17;
            this.drawsLbl.Text = "drawsLbl";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(187, 236);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(103, 37);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "&Clear Results";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.userChoiceLbl);
            this.groupBox2.Controls.Add(this.computerChoiceLbl);
            this.groupBox2.Controls.Add(this.resultLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(186, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "You Chose:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.winsLbl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.drawsLbl);
            this.groupBox3.Controls.Add(this.losesLbl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(186, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 84);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game stats";
            // 
            // RPSLS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPSLS_Form";
            this.Text = "Rock Paper Scissors Lizard Spock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}

