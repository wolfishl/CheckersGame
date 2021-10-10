using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form1 : Form
    {

        Button[,] board; 

        public Form1()
        {
            InitializeComponent();
            board = new Button [2, 8] { { square1 , square2, square3, square4, square5, square6, square7, square8 },
            { square9, square10, square11, square12, square13, square14, square15, square16 } };
        }

        public void DisplayButtonLocation(object sender)
        {
            Button btn = (Button)sender;
            var name = btn.Name;

            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board.Length; y++)
                {
                    if (board[x, y].Name == name)
                    {
                        MessageBox.Show($"Location of button is [{x + 1},{y + 1}]");
                        break;
                    }
                }
            }
        }

        private void square1_Click(object sender, EventArgs e)
        {
            DisplayButtonLocation(sender); 
        }
    }
}
