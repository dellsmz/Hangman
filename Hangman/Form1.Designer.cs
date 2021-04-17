
namespace Hangman
{
    partial class Hangman
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
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_Guess = new System.Windows.Forms.Button();
            this.LB_LivesLeftTxt = new System.Windows.Forms.Label();
            this.LB_LivesLeft = new System.Windows.Forms.Label();
            this.CharToGuess = new System.Windows.Forms.TextBox();
            this.LB_Char2 = new System.Windows.Forms.Label();
            this.LB_Char3 = new System.Windows.Forms.Label();
            this.LB_Char1 = new System.Windows.Forms.Label();
            this.LB_Char6 = new System.Windows.Forms.Label();
            this.LB_Char5 = new System.Windows.Forms.Label();
            this.LB_Char4 = new System.Windows.Forms.Label();
            this.TB_WongGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Label();
            this.Right_leg = new System.Windows.Forms.Label();
            this.Left_leg = new System.Windows.Forms.Label();
            this.Right_arm = new System.Windows.Forms.Label();
            this.Left_arm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.Peru;
            this.Btn_Play.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Play.Location = new System.Drawing.Point(734, 353);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(146, 68);
            this.Btn_Play.TabIndex = 0;
            this.Btn_Play.Text = "Play";
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Guess
            // 
            this.Btn_Guess.BackColor = System.Drawing.Color.Peru;
            this.Btn_Guess.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Guess.Location = new System.Drawing.Point(582, 353);
            this.Btn_Guess.Name = "Btn_Guess";
            this.Btn_Guess.Size = new System.Drawing.Size(146, 68);
            this.Btn_Guess.TabIndex = 1;
            this.Btn_Guess.Text = "Guess";
            this.Btn_Guess.UseVisualStyleBackColor = false;
            this.Btn_Guess.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_LivesLeftTxt
            // 
            this.LB_LivesLeftTxt.AutoSize = true;
            this.LB_LivesLeftTxt.Font = new System.Drawing.Font("Headline R", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_LivesLeftTxt.Location = new System.Drawing.Point(577, 301);
            this.LB_LivesLeftTxt.Name = "LB_LivesLeftTxt";
            this.LB_LivesLeftTxt.Size = new System.Drawing.Size(180, 26);
            this.LB_LivesLeftTxt.TabIndex = 3;
            this.LB_LivesLeftTxt.Text = "Lives Left:";
            this.LB_LivesLeftTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_LivesLeft
            // 
            this.LB_LivesLeft.AutoSize = true;
            this.LB_LivesLeft.Font = new System.Drawing.Font("Headline R", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_LivesLeft.Location = new System.Drawing.Point(763, 301);
            this.LB_LivesLeft.Name = "LB_LivesLeft";
            this.LB_LivesLeft.Size = new System.Drawing.Size(30, 26);
            this.LB_LivesLeft.TabIndex = 4;
            this.LB_LivesLeft.Text = "5";
            this.LB_LivesLeft.Click += new System.EventHandler(this.label2_Click);
            // 
            // CharToGuess
            // 
            this.CharToGuess.BackColor = System.Drawing.Color.DimGray;
            this.CharToGuess.Font = new System.Drawing.Font("Headline R", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CharToGuess.ForeColor = System.Drawing.Color.Black;
            this.CharToGuess.Location = new System.Drawing.Point(541, 366);
            this.CharToGuess.Name = "CharToGuess";
            this.CharToGuess.Size = new System.Drawing.Size(35, 36);
            this.CharToGuess.TabIndex = 5;
            // 
            // LB_Char2
            // 
            this.LB_Char2.AutoSize = true;
            this.LB_Char2.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char2.Location = new System.Drawing.Point(314, 264);
            this.LB_Char2.Name = "LB_Char2";
            this.LB_Char2.Size = new System.Drawing.Size(26, 26);
            this.LB_Char2.TabIndex = 6;
            this.LB_Char2.Text = "*";
            this.LB_Char2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LB_Char3
            // 
            this.LB_Char3.AutoSize = true;
            this.LB_Char3.BackColor = System.Drawing.Color.SaddleBrown;
            this.LB_Char3.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char3.Location = new System.Drawing.Point(355, 264);
            this.LB_Char3.Name = "LB_Char3";
            this.LB_Char3.Size = new System.Drawing.Size(26, 26);
            this.LB_Char3.TabIndex = 7;
            this.LB_Char3.Text = "*";
            // 
            // LB_Char1
            // 
            this.LB_Char1.AutoSize = true;
            this.LB_Char1.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char1.Location = new System.Drawing.Point(272, 264);
            this.LB_Char1.Name = "LB_Char1";
            this.LB_Char1.Size = new System.Drawing.Size(26, 26);
            this.LB_Char1.TabIndex = 8;
            this.LB_Char1.Text = "*";
            // 
            // LB_Char6
            // 
            this.LB_Char6.AutoSize = true;
            this.LB_Char6.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char6.Location = new System.Drawing.Point(480, 264);
            this.LB_Char6.Name = "LB_Char6";
            this.LB_Char6.Size = new System.Drawing.Size(26, 26);
            this.LB_Char6.TabIndex = 9;
            this.LB_Char6.Text = "*";
            // 
            // LB_Char5
            // 
            this.LB_Char5.AutoSize = true;
            this.LB_Char5.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char5.Location = new System.Drawing.Point(438, 264);
            this.LB_Char5.Name = "LB_Char5";
            this.LB_Char5.Size = new System.Drawing.Size(26, 26);
            this.LB_Char5.TabIndex = 10;
            this.LB_Char5.Text = "*";
            // 
            // LB_Char4
            // 
            this.LB_Char4.AutoSize = true;
            this.LB_Char4.Font = new System.Drawing.Font("Headline R", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_Char4.Location = new System.Drawing.Point(396, 264);
            this.LB_Char4.Name = "LB_Char4";
            this.LB_Char4.Size = new System.Drawing.Size(26, 26);
            this.LB_Char4.TabIndex = 11;
            this.LB_Char4.Text = "*";
            this.LB_Char4.Click += new System.EventHandler(this.LB_Char4_Click);
            // 
            // TB_WongGuess
            // 
            this.TB_WongGuess.BackColor = System.Drawing.Color.DimGray;
            this.TB_WongGuess.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_WongGuess.ForeColor = System.Drawing.Color.DarkRed;
            this.TB_WongGuess.Location = new System.Drawing.Point(606, 53);
            this.TB_WongGuess.Multiline = true;
            this.TB_WongGuess.Name = "TB_WongGuess";
            this.TB_WongGuess.Size = new System.Drawing.Size(274, 80);
            this.TB_WongGuess.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(644, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Incorrect Guesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(332, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter guess here:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 10);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 10);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 194);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(208, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 47);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Font = new System.Drawing.Font("Headline R", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Head.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Head.Location = new System.Drawing.Point(192, 145);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(44, 34);
            this.Head.TabIndex = 19;
            this.Head.Text = "O";
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.SaddleBrown;
            this.Body.Location = new System.Drawing.Point(208, 180);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(10, 61);
            this.Body.TabIndex = 20;
            // 
            // Right_leg
            // 
            this.Right_leg.BackColor = System.Drawing.Color.SaddleBrown;
            this.Right_leg.Location = new System.Drawing.Point(224, 231);
            this.Right_leg.Name = "Right_leg";
            this.Right_leg.Size = new System.Drawing.Size(10, 48);
            this.Right_leg.TabIndex = 21;
            // 
            // Left_leg
            // 
            this.Left_leg.BackColor = System.Drawing.Color.SaddleBrown;
            this.Left_leg.Location = new System.Drawing.Point(192, 231);
            this.Left_leg.Name = "Left_leg";
            this.Left_leg.Size = new System.Drawing.Size(10, 48);
            this.Left_leg.TabIndex = 22;
            // 
            // Right_arm
            // 
            this.Right_arm.BackColor = System.Drawing.Color.SaddleBrown;
            this.Right_arm.Location = new System.Drawing.Point(224, 197);
            this.Right_arm.Name = "Right_arm";
            this.Right_arm.Size = new System.Drawing.Size(48, 10);
            this.Right_arm.TabIndex = 23;
            // 
            // Left_arm
            // 
            this.Left_arm.BackColor = System.Drawing.Color.SaddleBrown;
            this.Left_arm.Location = new System.Drawing.Point(154, 197);
            this.Left_arm.Name = "Left_arm";
            this.Left_arm.Size = new System.Drawing.Size(48, 10);
            this.Left_arm.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(518, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Press play to start game and to reset. Press guess to inpt your guess.";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Left_arm);
            this.Controls.Add(this.Right_arm);
            this.Controls.Add(this.Left_leg);
            this.Controls.Add(this.Right_leg);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_WongGuess);
            this.Controls.Add(this.LB_Char4);
            this.Controls.Add(this.LB_Char5);
            this.Controls.Add(this.LB_Char6);
            this.Controls.Add(this.LB_Char1);
            this.Controls.Add(this.LB_Char3);
            this.Controls.Add(this.LB_Char2);
            this.Controls.Add(this.CharToGuess);
            this.Controls.Add(this.LB_LivesLeft);
            this.Controls.Add(this.LB_LivesLeftTxt);
            this.Controls.Add(this.Btn_Guess);
            this.Controls.Add(this.Btn_Play);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button Btn_Guess;
        private System.Windows.Forms.Label LB_LivesLeftTxt;
        private System.Windows.Forms.Label LB_LivesLeft;
        private System.Windows.Forms.TextBox CharToGuess;
        private System.Windows.Forms.Label LB_Char2;
        private System.Windows.Forms.Label LB_Char3;
        private System.Windows.Forms.Label LB_Char1;
        private System.Windows.Forms.Label LB_Char6;
        private System.Windows.Forms.Label LB_Char5;
        private System.Windows.Forms.Label LB_Char4;
        private System.Windows.Forms.TextBox TB_WongGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.Label Right_leg;
        private System.Windows.Forms.Label Left_leg;
        private System.Windows.Forms.Label Right_arm;
        private System.Windows.Forms.Label Left_arm;
        private System.Windows.Forms.Label label7;
    }
}

