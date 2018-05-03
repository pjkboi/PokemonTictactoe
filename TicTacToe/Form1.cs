//Program: Assignment 2
//Purpose: Designing and devopling a tictactoe game
//    Written by: PJ Khamvongsa
//    Last edited: 10/8/2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        const int PLAYER_X = 1;
        const int PLAYER_O = 2;
        const string X_WINS = "X wins";
        const string O_WINS = "O wins";
        int button;
        int [] space = new int[9];
        int turnCount; //whos turn
        int spaceCount = 0; //turn counter
        Image playerX = Properties.Resources.x;
        Image playerO = Properties.Resources.o;


        public void Restart()
        {
            btn1.Image = null;
            btn1.Enabled = true;
            btn2.Image = null;
            btn2.Enabled = true;
            btn3.Image = null;
            btn3.Enabled = true;
            btn4.Image = null;
            btn4.Enabled = true;
            btn5.Image = null;
            btn5.Enabled = true;
            btn6.Image = null;
            btn6.Enabled = true;
            btn7.Image = null;
            btn7.Enabled = true;
            btn8.Image = null;
            btn8.Enabled = true;
            btn9.Image = null;
            btn9.Enabled = true;
            spaceCount = 0;
            turnCount = PLAYER_X;
            for (int i = 0; i < 9; i++)
            {
                space[i] = 0;

            }
        }
        public void CheckWin()
        {
            //checking for vertical lines 
            for(int i = 0; i < 3; i++)
            {
                if(space[i]==space[i+3] && space[i+6]==space[i+3])
                {
                    if(space[i]==PLAYER_X)
                    {
                        MessageBox.Show(X_WINS);
                        Restart();
                    }
                    else if (space[i] == PLAYER_O)
                    {
                        MessageBox.Show(O_WINS);
                        Restart();
                    }
                }
            }
            //checking horizontal lines
            for (int i = 0; i < 9; i += 3)
            {
                if (space[i] == space[i + 1] && space[i + 1] == space[i + 2])
                {
                    if (space[i] == PLAYER_X)
                    {
                        MessageBox.Show(X_WINS);
                        Restart();
                    }
                    else if (space[i] == PLAYER_O)
                    {
                        MessageBox.Show(O_WINS);
                        Restart();
                    }
                }
            }

            //checking for diagonal lines
            if (space[2] == space[4] && space[4] == space[6])
            {
                if (space[4] == PLAYER_X)
                {
                    MessageBox.Show(X_WINS);
                    Restart();
                }
                else if (space[4] == PLAYER_O)
                {
                    MessageBox.Show(O_WINS);
                    Restart();
                }
            }
            if (space[0] == space[4] && space[4] == space[8])
            {
                if (space[4] == PLAYER_X)
                {
                    MessageBox.Show(X_WINS);
                    Restart();
                }
                else if (space[4] == PLAYER_O)
                {
                    MessageBox.Show("O wins");
                    Restart();
                }
            }
            //Checking for a DRAW
            if (spaceCount == 9)
            {
                MessageBox.Show("Draw");
                Restart();
            }


        }


        public TicTacToe()
        {
            InitializeComponent();
            turnCount = PLAYER_X;
            for (int i = 0; i < 9; i++)
            {
                space[i] = 0;

            }

        }
        public int PopulateButton(int button)
        {
            if (turnCount == PLAYER_X)
            {
                turnCount = PLAYER_O;
                space[button] = PLAYER_X;
                switch (button)
                {
                    case 0:
                        btn1.Image = playerX;
                        btn1.Enabled = false;
                        break;
                    case 1:
                        btn2.Image = playerX;
                        btn2.Enabled = false;
                        break;
                    case 2:
                        btn3.Image = playerX;
                        btn3.Enabled = false;
                        break;
                    case 3:
                        btn4.Image = playerX;
                        btn4.Enabled = false;
                        break;
                    case 4:
                        btn5.Image = playerX;
                        btn5.Enabled = false;
                        break;
                    case 5:
                        btn6.Image = playerX;
                        btn6.Enabled = false;
                        break;
                    case 6:
                        btn7.Image = playerX;
                        btn7.Enabled = false;
                        break;
                    case 7:
                        btn8.Image = playerX;
                        btn8.Enabled = false;
                        break;
                    case 8:
                        btn9.Image = playerX;
                        btn9.Enabled = false;
                        break;

                }
            }
            else if (turnCount == PLAYER_O)
            {
                turnCount = PLAYER_X;
                space[button] = PLAYER_O;
                switch (button)
                {
                    case 0:
                        btn1.Image = playerO;
                        btn1.Enabled = false;
                        break;
                    case 1:
                        btn2.Image = playerO;
                        btn2.Enabled = false;
                        break;
                    case 2:
                        btn3.Image = playerO;
                        btn3.Enabled = false;
                        break;
                    case 3:
                        btn4.Image = playerO;
                        btn4.Enabled = false;
                        break;
                    case 4:
                        btn5.Image = playerO;
                        btn5.Enabled = false;
                        break;
                    case 5:
                        btn6.Image = playerO;
                        btn6.Enabled = false;
                        break;
                    case 6:
                        btn7.Image = playerO;
                        btn7.Enabled = false;
                        break;
                    case 7:
                        btn8.Image = playerO;
                        btn8.Enabled = false;
                        break;
                    case 8:
                        btn9.Image = playerO;
                        btn9.Enabled = false;
                        break;
                }

            }

            spaceCount++;
            return (turnCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = 0;
            PopulateButton(button);
            CheckWin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button = 2;
            
            PopulateButton(button);
            CheckWin();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            button = 1;
            PopulateButton(button);
            CheckWin();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            button = 3;
            PopulateButton(button);
            CheckWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            button = 4;
            PopulateButton(button);
            CheckWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            button = 5;
            PopulateButton(button);
            CheckWin();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            button = 6;
            PopulateButton(button);
            CheckWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            button = 7;
            PopulateButton(button);
            CheckWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            button = 8;
            PopulateButton(button);
            CheckWin();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
