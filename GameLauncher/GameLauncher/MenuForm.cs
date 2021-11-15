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
            MenuForm f2 = new MenuForm();
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
        }
    }
}
