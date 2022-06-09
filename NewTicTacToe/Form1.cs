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
        bool opponent = true; //opponent is used as vriable for players
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
        }
    }
}
