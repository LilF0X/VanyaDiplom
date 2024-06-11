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
    public partial class FormLessons : Form
    {
        public FormLessons()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addstring = $"INSERT INTO менегерс([Код тренера], [Код вида занятий], [Номер дня недели], [Номер зала]) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}')";

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(addstring, connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Успешно добавлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deletestring = $"DELETE FROM менегерс WHERE ид='{textBox5.Text}'";

            SqlConnection connect = ClassConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(deletestring, connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Удалено успешно");
        }
    }
}
