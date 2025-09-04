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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crud_operation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "Insert into student(EnrlNo,Name,Age,City) VALUES(@Enroll,@Name,@Age,@City)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Enroll", txtEnrlNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conStr = "";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            string query = "UPDATE  crud1 Set Name=@Name;
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@EnrolNo", txtEnrolNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conStr = "";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conStr = "";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.Parameters.AddWithValue("",);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
