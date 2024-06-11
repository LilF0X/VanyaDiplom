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
    public partial class FormAddManager : Form
    {
        public FormAddManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addmanstring = $"INSERT INTO менегерс(Логин, пароль, доустп) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}')";

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(addmanstring, connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Успешно добавлено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deletestring = $"DELETE FROM менегерс WHERE ид='{textBox4.Text}'";

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(deletestring, connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Удалено успешно");
        }
    }
}
