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

namespace VanyaDiplom
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querystring = $"SELECT доступ FROM юзер WHERE Логин='{textBox1.Text}' AND Пароль='{textBox2.Text}'"; //сюда отредактируй имена запроса. Если по пизде пойдёт, то имена таблицы и столбцов в квадратные скобки заключи []*

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(querystring, connect);

            object Role = cmd.ExecuteScalar();

            if (Role != null)
            {
                switch(Role)
                {
                    case 0:
                        this.Hide();
                        
                        break;

                    case 1:
                        this.Hide();

                        break;

                    case 2:
                        this.Hide();

                        break;

                    case 3:
                        this.Hide();

                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistration reg = new FormRegistration();
            reg.Show();
        }
    }
}
