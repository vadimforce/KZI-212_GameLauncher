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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameXandO f2 = new GameXandO();
            f2.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Крестики Нолики");
            ToolTip t1 = new ToolTip();
            t.SetToolTip(pictureBox6, "Тетрис");
            ToolTip t3 = new ToolTip();
            t.SetToolTip(pictureBox7, "Сапёр");
            ToolTip t4 = new ToolTip();
            t.SetToolTip(pictureBox8, "Шашки");
            ToolTip t5 = new ToolTip();
            t.SetToolTip(pictureBox9, "Кликер");
            ToolTip t6 = new ToolTip();
            t.SetToolTip(pictureBox2, "Арканоид");
            ToolTip t7 = new ToolTip();
            t.SetToolTip(pictureBox10, "2048");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение GameLauncher позволяет выбрать среди списка доступных игр и непосредственно поиграть в них. Мы - оффлайн-сервис игр, разработанный (и поддерживаемый) студентами группы КЗИ-212 Омского Гоcударственного Технического Университета. Приятной игры!");
        }
        Point lastPoint;
        private void MenuForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Checkers f3 = new Checkers();
            f3.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Saper f4 = new Saper();
            f4.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Arcanoid f5 = new Arcanoid();
            f5.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Phisycs f6 = new Phisycs();
            f6.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Klicker f9 = new Klicker();
            f9.Show();
            this.Hide();
        }
    }
}