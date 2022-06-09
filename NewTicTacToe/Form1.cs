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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoard01_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard01.Text = "X";
                opponent = !opponent;
                btnBoard01.Text = "X"; btnBoard01.Enabled = false;
            }
            else
            {
                btnBoard01.Text = "O";
                opponent = !opponent;
                btnBoard01.Text = "O"; btnBoard01.Enabled = false;
            }
            //Checking of Winner for 1st button
            //Winner in Horizontal = btnBoard 01, 02, and 03.
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard02_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard02.Text = "X";
                opponent = !opponent;
                btnBoard02.Text = "X"; btnBoard02.Enabled = false;
            }
            else
            {
                btnBoard02.Text = "O";
                opponent = !opponent;
                btnBoard02.Text = "O"; btnBoard02.Enabled = false;
            }
            //Checking of Winner for 2nd button
            //Winner in Horizontal = btnBoard 01, 02, 03
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard03_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard03.Text = "X";
                opponent = !opponent;
                btnBoard03.Text = "X"; btnBoard03.Enabled = false;
            }
            else
            {
                btnBoard03.Text = "O";
                opponent = !opponent;
                btnBoard03.Text = "O"; btnBoard03.Enabled = false;
            }
            //Checking of Winner for 3rd button
            //Winner in Horizontal = btnBoard 01, 02, 03
            if (btnBoard01.Text == "X" && btnBoard02.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard02.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Diagonal = btnBoard 03, 05, 07
            if (btnBoard03.Text == "X" && btnBoard05.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard03.Text == "O" && btnBoard05.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard04_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard04.Text = "X";
                opponent = !opponent;
                btnBoard04.Text = "X"; btnBoard04.Enabled = false;
            }
            else
            {
                btnBoard04.Text = "O";
                opponent = !opponent;
                btnBoard04.Text = "O"; btnBoard04.Enabled = false;
            }
            //Checking of Winner for 4th button
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard05_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard05.Text = "X";
                opponent = !opponent;
                btnBoard05.Text = "X"; btnBoard05.Enabled = false;
            }
            else
            {
                btnBoard05.Text = "O";
                opponent = !opponent;
                btnBoard05.Text = "O"; btnBoard05.Enabled = false;
            }
            //Checking of Winner for 5th button
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard06_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard06.Text = "X";
                opponent = !opponent;
                btnBoard06.Text = "X"; btnBoard06.Enabled = false;
            }
            else
            {
                btnBoard06.Text = "O";
                opponent = !opponent;
                btnBoard06.Text = "O"; btnBoard06.Enabled = false;
            }
            //Checking of Winner for 6th button
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Horizontal = btnBoard 04, 05, 06
            if (btnBoard04.Text == "X" && btnBoard05.Text == "X" && btnBoard06.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard04.Text == "O" && btnBoard05.Text == "O" && btnBoard06.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard07_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard07.Text = "X";
                opponent = !opponent;
                btnBoard07.Text = "X"; btnBoard07.Enabled = false;
            }
            else
            {
                btnBoard07.Text = "O";
                opponent = !opponent;
                btnBoard07.Text = "O"; btnBoard07.Enabled = false;
            }
            //Checking of Winner for 7th button
            //Winner in Vertical = btnBoard 01, 04, 07
            if (btnBoard01.Text == "X" && btnBoard04.Text == "X" && btnBoard07.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard04.Text == "O" && btnBoard07.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Diagonal = btnBoard 07, 05, 03
            if (btnBoard07.Text == "X" && btnBoard05.Text == "X" && btnBoard03.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard07.Text == "O" && btnBoard05.Text == "O" && btnBoard03.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard08_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard08.Text = "X";
                opponent = !opponent;
                btnBoard08.Text = "X"; btnBoard08.Enabled = false;
            }
            else
            {
                btnBoard08.Text = "O";
                opponent = !opponent;
                btnBoard08.Text = "O"; btnBoard08.Enabled = false;
            }
            //Checking of Winner for 8th button
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Vertical = btnBoard 02, 05, 08
            if (btnBoard02.Text == "X" && btnBoard05.Text == "X" && btnBoard08.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard02.Text == "O" && btnBoard05.Text == "O" && btnBoard08.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }

        private void btnBoard09_Click(object sender, EventArgs e)
        {
            if (opponent)
            {
                btnBoard09.Text = "X";
                opponent = !opponent;
                btnBoard09.Text = "X"; btnBoard09.Enabled = false;
            }
            else
            {
                btnBoard09.Text = "O";
                opponent = !opponent;
                btnBoard09.Text = "O"; btnBoard09.Enabled = false;
            }
            //Checking of Winner for 9th button
            //Winner in Vertical = btnBoard 03, 06, 09
            if (btnBoard03.Text == "X" && btnBoard06.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard03.Text == "O" && btnBoard06.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Horizontal = btnBoard 07, 08, 09
            if (btnBoard07.Text == "X" && btnBoard08.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard07.Text == "O" && btnBoard08.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
            //Winner in Diagonal = btnBoard 01, 05, 09
            if (btnBoard01.Text == "X" && btnBoard05.Text == "X" && btnBoard09.Text == "X")
            {
                MessageBox.Show("Congratulations Player X you've won the game!!!");
            }
            if (btnBoard01.Text == "O" && btnBoard05.Text == "O" && btnBoard09.Text == "O")
            {
                MessageBox.Show("Congratulations Player O you've won the game!!!");
            }
        }
    }
}
