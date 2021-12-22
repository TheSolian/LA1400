using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_1400_Croissant
{
    public partial class GameScreen : Form
    {


        private int whichPylon = 0;
        private int balance = 50;
        private int betAmount = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Diesen Code auch im Shop verwenden
            Form form1 = new Menu();
            this.Visible = false;
            form1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            whichPylon = new Random().Next(1,3);
            label1.Text = "Balance: " + balance;
            label2.Text = "0";

            label3.Text = Convert.ToString(whichPylon);

            buttonRestart.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (whichPylon == 1)
            {
                gameButton1.Location = new Point(100, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You won");

                betAmount = betAmount * 2;
                balance = balance + betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
            else
            {
                gameButton1.Location = new Point(100, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You lose!");

                balance = balance - betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (whichPylon == 3)
            {
                gameButton3.Location = new Point(600, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You won!");

                betAmount = betAmount * 2;
                balance = balance + betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
            else
            {
                gameButton3.Location = new Point(600, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You lose!");

                balance = balance - betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (whichPylon == 2)
            {
                gameButton2.Location = new Point(350, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You won");

                betAmount = betAmount * 2;
                balance = balance + betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
            else
            {
                gameButton2.Location = new Point(350, 120);
                gameButton1.Enabled = false;
                gameButton2.Enabled = false;
                gameButton3.Enabled = false;
                MessageBox.Show("You lose!");

                balance = balance - betAmount;
                label1.Text = "V-Bucks: " + Convert.ToString(balance);

                betAmount = 0;
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);

                buttonRestart.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            betAmount = int.Parse(textBox1.Text);

            if (balance >= betAmount)
            {
                label2.Text = "Your Bet: " + Convert.ToString(betAmount);
            }
            else
            {
                label2.Text = "Not enough V-Bucks!";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            gameButton1.Location = new Point(100, 280);
            gameButton2.Location = new Point(350, 280);
            gameButton3.Location = new Point(600, 280);
            gameButton1.Enabled = true;
            gameButton2.Enabled = true;
            gameButton3.Enabled = true;
            whichPylon = new Random().Next(1, 3);
            label3.Text = Convert.ToString(whichPylon);
            buttonRestart.Hide();
        }
    }
}
