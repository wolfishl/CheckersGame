using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form2 : Form
    {
        int rowClicked;
        int columnClicked;
        bool validEntry = false;
        public Form2(int row, int column)
        {
            InitializeComponent();
            rowClicked = row;
            columnClicked = column;
            currentRow.Text = "Current Row: " + row;
            currentColumn.Text = "Current Column: " + column;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //TODO: add rules for jumping over
        private void ok_Click(object sender, EventArgs e) 
        {
            int.TryParse(rowComboBox.Text, out int comboBoxRow);
            int.TryParse(columnComboBox.Text, out int comboBoxColumn);
            if (comboBoxRow == rowClicked + 1 || comboBoxRow == rowClicked - 1)
            {
                if (comboBoxColumn == columnClicked + 1 || comboBoxColumn == columnClicked + 1)
                {
                    errorMessage.Text = "";
                    validEntry = true;
                    this.Close();
                }
                else
                {
                    errorMessage.Text = "Invalid move";
                }
            }
            else
            {
               errorMessage.Text = "Invalid move";
               
            }
        }

        public int getComboBoxRow()
        {
            return int.Parse(rowComboBox.Text);
        }

        public int getComboBoxColumn()
        {
            return int.Parse(columnComboBox.Text);
        }

        public bool getValidEntry()
        {
            return validEntry;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
