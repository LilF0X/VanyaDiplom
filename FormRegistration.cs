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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querystring = $"INSERT INTO пользователи(логен, парол, доступе) VALUES ('{textBox1.Text}', '{textBox2.Text}', число_уровня_доступа)"; //тут не забудь запрос поменять

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(querystring, connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Успешная регистрация!");
        }
    }
}
