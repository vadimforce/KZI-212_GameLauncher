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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegisterForm f3 = new RegisterForm();
            f3.Show();
            this.Hide();
        }
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\GameLauncherDB.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0) // проверяем введён ли логин     
            {
                if (textBox4.Text.Length > 0) // проверяем введён ли пароль
                {
                    DataTable dt_user = Select("SELECT * FROM [dbo].[Users] WHERE [login] = '" + textBox3.Text + "' AND [password] = '" + textBox4.Text + "'");
                    if (dt_user.Rows.Count > 0)
                    {

                        MessageBox.Show("Добро Пожаловать!");

                        this.Hide();
                        MenuForm f = new MenuForm();
                        f.Show();
                    }
                            else MessageBox.Show("Пользователь не найден");
                        }
                else MessageBox.Show("Введите пароль!");

            }
            else MessageBox.Show("Введите логин!");
        }
            }

        }
    

