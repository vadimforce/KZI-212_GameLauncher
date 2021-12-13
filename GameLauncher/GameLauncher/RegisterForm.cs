using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox3.Text.Length == 0)
                {
                    MessageBox.Show("Укажите логин");
                    textBox3.Focus();
                }
                else
                {
                    string login = textBox3.Text;
                    string password = textBox4.Text;


                    if (textBox4.Text.Length == 0)
                    {
                        MessageBox.Show("Укажите пароль");
                        textBox4.Focus();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\GameLauncherDB.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into Users (login, password) values('" + login + "','" + password + "')", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Новый пользователь успешно зарегистрирован в системе!");
                        MenuForm f2 = new MenuForm();
                        f2.Show();
                        this.Hide();
                    }

                }
            }
        }
    }
}
