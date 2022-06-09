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
            }
            else
            {
                btnBoard01.Text = "O";
                opponent = !opponent;
            }
        }
    }
}
