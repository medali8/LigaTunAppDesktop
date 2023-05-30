using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ligaTun
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.conn = new MySqlConnection();
            this.conn.ConnectionString = "server=localhost;uid=root;pwd=;database=ligatun";
            try
            {
                this.conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("erreur");
            }
            string login = logTxt.Text.Trim();
            string pwd = pwdTxt.Text.Trim();
            MySqlCommand cmd = new MySqlCommand("select fonctionAd from admin where loginAd='"+login+"'and pwdAd='"+pwd+"'" , this.conn);
            
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
            
            
                string fct = reader.GetString(0);
           
            if (fct == "superAdmin")
            {
                this.Hide();
                Form1 f5 = new Form1();
                f5.Show();
            } else if (fct == "MKT&SALES")
            {
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }
            else if (fct == "CXP")
            {
                this.Hide();
                Form7 f7= new Form7();  
                f7.Show();
                
            }

           
            

           
        }
    }
}
