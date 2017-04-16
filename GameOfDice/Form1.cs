using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfDice
{
    public partial class Form1 : Form
    {
        int player_one, player_two, sum_one, sum_two, rounds;
        int count_one;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random round = new Random();
            player_one = round.Next(1, 7);
            MessageBox.Show(" Numero: " + player_one);
            sum_one += player_one;
            rounds++;
            count_one++;
            if (count_one == 3)
            {
                MessageBox.Show("Time of the second player !");
            }
            if (rounds == 6)
            {
                premium();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random round = new Random();
            player_two = round.Next(1, 7);
            MessageBox.Show(" Numero: " + player_two);
            sum_two += player_two;
            rounds++;
            if (rounds == 6)
            {
                premium();
            }
        }

        public void premium()
        {
            if (sum_one > sum_two)
            {
                MessageBox.Show("Player One WINS !!!");
                rounds = 0;
                
            }
            else if (sum_one < sum_two)
            {
                MessageBox.Show("Player Two WINS !!!");
                rounds = 0;
            }
            else
            {
                MessageBox.Show("Tie");
                rounds = 0;
            }
        }
    }
}
