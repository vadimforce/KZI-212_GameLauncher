using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class GameXandO : Form
    {
        bool xTurn = true;
        public GameXandO()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if (xTurn)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xTurn = !xTurn;
            senderB.Enabled = false;
            CheckWin();
        }
        void CheckWin()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили " + button1.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + button4.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победили " + button7.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победили " + button1.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button3.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + button3.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled == false)
            {
                MessageBox.Show("Победили " + button3.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false)
            {
                MessageBox.Show("Победили " + button1.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + button3.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили " + button2.Text);
                GameXandO f2 = new GameXandO();
                this.Hide();
                f2.Show();
            }
        }

        private void GameXandO_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.Show();
            this.Hide();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3×3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выигрывает. Первый ход делает игрок, ставящий крестики.");
        }
    }
}