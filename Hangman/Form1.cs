using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{

    //==================================================//
    // Author: Dell, Zach                               //
    // Description: A hangman game with six letter words//
    //                                                  //
    // Capstone Project                                 //
    //                                                  //
    // Date created: 4/15/21                            //
    // Last Modified: 4/17/21                           //
    //==================================================

    public partial class Hangman : Form
    {
       

        #region Tools
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LB_Char4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TB_CharToGuess(object sender, EventArgs e)
        {

        }
        #endregion

        #region Code
        public Hangman()
        {
            InitializeComponent();
        }
         string SecretWord;
        int LivesLeft = 5;
        bool c1Guessed, c2Guessed, c3Guessed, c4Guessed, c5Guessed, c6Guessed, Won;
        char c1, c2, c3, c4, c5, c6;
        
        // Resets game

        void Resetter()
        {
            Won = false; c1Guessed = false; c2Guessed = false; c3Guessed = false; c4Guessed = false; c5Guessed = false; c6Guessed = false;
            
            Btn_Guess.Visible = true;

            CharToGuess.Text = ""; LB_Char1.Text = "*"; LB_Char2.Text = "*"; LB_Char3.Text = "*"; LB_Char4.Text = "*"; LB_Char5.Text = "*"; LB_Char6.Text = "*";

            TB_WongGuess.Text = "";

            LB_LivesLeft.Text = "5";
            LivesLeft = 5;

            Left_arm.BackColor = Color.SaddleBrown; Left_leg.BackColor = Color.SaddleBrown; Right_arm.BackColor = Color.SaddleBrown; Right_leg.BackColor = Color.SaddleBrown; Head.ForeColor = Color.SaddleBrown; Body.BackColor = Color.SaddleBrown;
        }
        // (Play Button) Generates new secret word

        private void button1_Click(object sender, EventArgs e)
        {
            Resetter();
            
            SecretWord = GetWord.WordGetter();
            c1 = SecretWord[0]; c2 = SecretWord[1]; c3 = SecretWord[2]; c4 = SecretWord[3]; c5 = SecretWord[4]; c6 = SecretWord[5];
            LB_LivesLeft.Text = LivesLeft.ToString();
            
            // Displays message telling what the word is (For testing only)
            MessageBox.Show(SecretWord);
            MessageBox.Show("A new secret word has been generated", "Hangman");
        }
        
        // (Guess Button) Guesses entered letter
        private void button2_Click(object sender, EventArgs e)
        {
            
            // Blocks entering mulipul guesses at once
            if (CharToGuess.Text.Length > 1)
            {
                MessageBox.Show("Please only enter one letter at a time!", "Hangman");
                CharToGuess.Text = "";
            }

            // Displays message saying guess was already entered
            if (TB_WongGuess.Text.Contains(CharToGuess.Text))
            {
                MessageBox.Show("You have already guessed " + TB_WongGuess, "Hangman");
                CharToGuess.Text = "";
            }
            
            // Testes to see if guess is apart of word and displays guess
            // in its position (either on the line or in incorrect box)
            if (SecretWord.Contains(CharToGuess.Text.ToLower()))
            {
                if (CharToGuess.Text == c1.ToString())
                {
                    LB_Char1.Text = c1.ToString();
                    c1Guessed = true;
                    CharToGuess.Text = "";
                }

                if (CharToGuess.Text == c2.ToString())
                {
                    LB_Char2.Text = c2.ToString();
                    c2Guessed = true;
                    CharToGuess.Text = "";
                }

                if (CharToGuess.Text == c3.ToString())
                {
                    LB_Char3.Text = c3.ToString();
                    c3Guessed = true;
                    CharToGuess.Text = "";
                }

                if (CharToGuess.Text == c4.ToString())
                {
                    LB_Char4.Text = c4.ToString();
                    c4Guessed = true;
                    CharToGuess.Text = "";
                }

                if (CharToGuess.Text == c5.ToString())
                {
                    LB_Char5.Text = c5.ToString();
                    c5Guessed = true;
                    CharToGuess.Text = "";
                }

                if (CharToGuess.Text == c6.ToString())
                {
                    LB_Char6.Text = c6.ToString();
                    c6Guessed = true;
                    CharToGuess.Text = "";
                }

                if (c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed && c6Guessed)
                {
                    Won = true;
                }

                // Displays message saying you have won
                if (Won)
                {
                    MessageBox.Show("You won with " + LivesLeft.ToString() + " Lives left", "Hangman");
                }
            }
            else
            {
                // Tests for wrong guess and reduces life count
                LivesLeft--;
                LB_LivesLeft.Text = LivesLeft.ToString();
                TB_WongGuess.Text += CharToGuess.Text;

                CharToGuess.Text = "";

                // Shows parts of the hangman when guessing wrong
                if (LB_LivesLeft.Text == "4")
                {
                    Head.ForeColor = Color.Black;
                    Body.BackColor = Color.Black;
                }
                if (LB_LivesLeft.Text == "3")
                {
                    Right_arm.BackColor = Color.Black;
                }
                if (LB_LivesLeft.Text == "2")
                {
                    Left_arm.BackColor = Color.Black;
                }
                if (LB_LivesLeft.Text == "1")
                {
                    Left_leg.BackColor = Color.Black;
                }
                if (LB_LivesLeft.Text == "0")
                {
                    Right_leg.BackColor = Color.Black;
                }

                // Displays message informing out of lives
                if (LB_LivesLeft.Text == "0")
                {
                    MessageBox.Show("You have lost! The secret word was: " + SecretWord);
                    Won = false;
                    Btn_Guess.Visible = false;
                }

            }  

            

            

        }
        #endregion

    }
}