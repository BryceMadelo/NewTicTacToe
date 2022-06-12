using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTicTacToe
{
    public partial class Form1 : Form
    {
        bool opponent = true; //opponent is used as variable for players
        int opponent_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawChecker()//Checks the draw
        {
            if (opponent_count == 9)
            {
                MessageBox.Show("The game is draw! Please press RESTART to play again:)");
            }
        }
        private void btnBoard01_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard01.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard01.Enabled = false;
                btnBoard01.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard01.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard01.Enabled = false;
                btnBoard01.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 1st button
            //Winner in Horizontal = btnBoard 01, 02, and 03.
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard02_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard02.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard02.Enabled = false;
                btnBoard02.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard02.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard02.Enabled = false;
                btnBoard02.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 2nd button
            //Winner in Horizontal = btnBoard 01, 02, 03
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard03_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard03.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard03.Enabled = false;
                btnBoard03.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard03.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard03.Enabled = false;
                btnBoard03.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 3rd button
            //Winner in Horizontal = btnBoard 01, 02, 03
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Diagonal = btnBoard 03, 05, 07
            if (btnBoard03.Text == "X" && btnBoard05.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard03.Text == "O" && btnBoard05.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard04_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard04.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard04.Enabled = false;
                btnBoard04.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard04.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard04.Enabled = false;
                btnBoard04.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 4th button
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard05_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard05.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard05.Enabled = false;
                btnBoard05.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard05.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard05.Enabled = false;
                btnBoard05.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 5th button
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
        }
        private void btnBoard06_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard06.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard06.Enabled = false;
                btnBoard06.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard06.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard06.Enabled = false;
                btnBoard06.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 6th button
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard07_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard07.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard07.Enabled = false;
                btnBoard07.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard07.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard07.Enabled = false;
                btnBoard07.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 7th button
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Diagonal = btnBoard 07, 05, 03
            if (btnBoard07.Text == "X" && btnBoard05.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard07.Text == "O" && btnBoard05.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
        }
        private void btnBoard08_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard08.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard08.Enabled = false;
                btnBoard08.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard08.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard08.Enabled = false;
                btnBoard08.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 8th button
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoard09_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard09.Text = "X";
                opponent = !opponent;
                opponent_count++;
                btnBoard09.Enabled = false;
                btnBoard09.BackColor = Color.PaleVioletRed;
            }
            else
            {
                btnBoard09.Text = "O";
                opponent = !opponent;
                opponent_count++;
                btnBoard09.Enabled = false;
                btnBoard09.BackColor = Color.LimeGreen;
            }
            //Checking of Winner for 9th button
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
                btnBoard01.Enabled = false;
                btnBoard02.Enabled = false;
                btnBoard03.Enabled = false;
                btnBoard04.Enabled = false;
                btnBoard05.Enabled = false;
                btnBoard06.Enabled = false;
                btnBoard07.Enabled = false;
                btnBoard08.Enabled = false;
                btnBoard09.Enabled = false;
            }
            DrawChecker();
        }
        private void btnBoardAll_Click(object sender, EventArgs e)
        {
            
        }
        private void GameInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RULES FOR TIC-TAC-TOE.                                                                               -The game is played on a grid that's 3 squares by 3 squares.                      -You are X, and the other player is O.                                                         -The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. ");
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
