using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //O corrisponds to 2 and X to 1.
        int[,] gameBoard = new int[3, 3];

        //Checks for win conditions
        private void winCondition()
        {
            //Loops through the fist dimension of the gameBoard array and checks for win conditions
            for(int index = 0; index < gameBoard.GetLength(0); index++)
            {
                if (gameBoard[index, 0].Equals(2) && gameBoard[index, 1].Equals(2) && gameBoard[index, 2].Equals(2)) {
                    endMessage.Text = "O Wins!!!";
                    enableTiles(false);
                }
                else if (gameBoard[index, 0].Equals(1) && gameBoard[index, 1].Equals(1) && gameBoard[index, 2].Equals(1))
                {
                    endMessage.Text = "X Wins!!!";
                    enableTiles(false);
                }
                else if (gameBoard[0, index].Equals(2) && gameBoard[1, index].Equals(2) && gameBoard[2, index].Equals(2))
                {
                    endMessage.Text = "O Wins!!!";
                    enableTiles(false);
                }
                else if (gameBoard[0, index].Equals(1) && gameBoard[1, index].Equals(1) && gameBoard[2, index].Equals(1))
                {
                    endMessage.Text = "X Wins!!!";
                    enableTiles(false);
                }
                else if((gameBoard[0, 2].Equals(1) && gameBoard[1, 1].Equals(1) && gameBoard[2, 0].Equals(1)) 
                    || (gameBoard[0, 0].Equals(1) && gameBoard[1, 1].Equals(1) && gameBoard[2, 2].Equals(1)))
                {
                    endMessage.Text = "X Wins!!!";
                    enableTiles(false);
                }
                else if ((gameBoard[0, 2].Equals(2) && gameBoard[1, 1].Equals(2) && gameBoard[2, 0].Equals(2)) 
                    || (gameBoard[0, 0].Equals(2) && gameBoard[1, 1].Equals(2) && gameBoard[2, 2].Equals(2)))
                {
                    endMessage.Text = "O Wins!!!";
                    enableTiles(false);
                }
            }
            //Runs if winner has not been decided
            if(endMessage.Text == "")
            {
                //Represents all available spaces on the board
                int availableSpace = 9;
                //for loop and nested for loop to check if every space has been played
                for (int row = 0; row < gameBoard.GetLength(0); row++)
                {
                    for (int column = 0; column < gameBoard.GetLength(0); column++)
                    {
                        if (gameBoard[row, column].Equals(1) || gameBoard[row, column].Equals(2)) {
                            //Removes one from the available spaces on the board
                            availableSpace--;
                        }
                    }
                }
                //If all available spaces are taken up game is declared a draw.
                if(availableSpace.Equals(0))
                {
                    endMessage.Text = "Draw!!!";
                    enableTiles(false);
                }
            }
            
        }
        //Used to visually show whose turn it is. Will also call method to check for win conditons.
        private void enableO()
        {
            xBtn.Enabled = false;
            oBtn.Enabled = true;
            winCondition();
        }
        //Used to visually show whose turn it is. Will also call method to check for win conditons.
        private void enableX()
        {
            oBtn.Enabled = false;
            xBtn.Enabled = true;
            winCondition();
        }

        //Enables all tiles when new game begins
        private void enableTiles(bool enable)
        {
            label1.Enabled = enable;
            label2.Enabled = enable;
            label3.Enabled = enable;
            label4.Enabled = enable;
            label5.Enabled = enable;
            label6.Enabled = enable;
            label7.Enabled = enable;
            label8.Enabled = enable;
            label9.Enabled = enable;
        }

        //Clears all tiles for fresh game board
        private void clearTiles() {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label9.Text = "";
            label8.Text = "";
        }

        //Manually switches to O's turn
        private void xBtn_Click(object sender, EventArgs e)
        {
            enableO();
        }
        //Manually switches to X's turn
        private void oBtn_Click(object sender, EventArgs e)
        {
            enableX();
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label1_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label1.Text == "")
            {
                label1.Text = "O";
                gameBoard[0, 0] = 2;
                enableX();
            }
            else if(xBtn.Enabled == true && label1.Text == "")
            {
                label1.Text = "X";
                gameBoard[0, 0] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label2_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label2.Text == "")
            {
                label2.Text = "O";
                gameBoard[0, 1] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label2.Text == "")
            {
                label2.Text = "X";
                gameBoard[0, 1] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label3_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label3.Text == "")
            {
                label3.Text = "O";
                gameBoard[0, 2] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label3.Text == "")
            {
                label3.Text = "X";
                gameBoard[0, 2] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label4_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label4.Text == "")
            {
                label4.Text = "O";
                gameBoard[1, 0] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label4.Text == "")
            {
                label4.Text = "X";
                gameBoard[1, 0] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label5_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label5.Text == "")
            {
                label5.Text = "O";
                gameBoard[1, 1] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label5.Text == "")
            {
                label5.Text = "X";
                gameBoard[1, 1] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label6_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label6.Text == "")
            {
                label6.Text = "O";
                gameBoard[1, 2] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label6.Text == "")
            {
                label6.Text = "X";
                gameBoard[1, 2] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label7_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label7.Text == "")
            {
                label7.Text = "O";
                gameBoard[2, 0] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label7.Text == "")
            {
                label7.Text = "X";
                gameBoard[2, 0] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label8_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label8.Text == "")
            {
                label8.Text = "O";
                gameBoard[2, 1] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label8.Text == "")
            {
                label8.Text = "X";
                gameBoard[2, 1] = 1;
                enableO();
            }
        }

        //Checks if it is X turn or O turn 
        //Displays corrisponding letter in label and records corrisponding integer in gameBoard if label is empty
        private void label9_Click(object sender, EventArgs e)
        {
            if (oBtn.Enabled == true && label9.Text == "")
            {
                label9.Text = "O";
                gameBoard[2, 2] = 2;
                enableX();
            }
            else if (xBtn.Enabled == true && label9.Text == "")
            {
                label9.Text = "X";
                gameBoard[2, 2] = 1;
                enableO();
            }
        }

        //Enables game tiles and buttons for game to start.
        private void startGame_Click(object sender, EventArgs e)
        {
            enableTiles(true);
            startGame.Enabled = false;
            newGame.Enabled = true;
            xBtn.Enabled = true;
        }

        //Resets the board, clears the game board array for a new game.
        private void newGame_Click(object sender, EventArgs e)
        {
            clearTiles();
            enableTiles(false);
            startGame.Enabled = true;
            xBtn.Enabled = false;
            oBtn.Enabled = false;
            newGame.Enabled = false;
            Array.Clear(gameBoard, 0, 9);
            endMessage.Text = "";
        }
    }
}
