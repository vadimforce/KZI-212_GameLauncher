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
    public partial class Klicker : Form
    {
        public Klicker()
        {
            InitializeComponent();
        }
        int score = 0;
        int x = 1;
        int c = 1;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += x;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label5.Text = "" + score;
        }

        private void Klicker_Load(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(pictureBox1, "НАЖМИ НА МЕНЯ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(score>100)
            {
                score -= 100;
                c += 1;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (score > 900)
            {
                score -= 900;
                c += 10;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (score > 8000)
            {
                score -= 8000;
                c += 100;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (score > 70000)
            {
                score -= 70000;
                c += 1000;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (score > 10)
            {
                score -= 10;
                x += 1;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score > 90)
            {
                score -= 90;
                x += 10;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (score > 800)
            {
                score -= 800;
                x += 100;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (score > 7000)
            {
                score -= 7000;
                x += 1000;
            }
            else
            {
                MessageBox.Show("У вас недостаточно очков для улучшения");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            score += c;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликер - это игра, игровой процесс в которой состоит из кликов по монетке. Нажатия выполняются, чтобы заработать игровую валюту, которую можно трарить на различные улучшения");
        }
    }
}
