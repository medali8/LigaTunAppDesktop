using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ligaTun
{
    public partial class Form7 : Form
    {
        
        MySqlConnection conn;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lister_clients();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Lister_clients()
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
            string sql = "SELECT c.Cin,c.Nom,c.prenom,c.gouvernorat,c.Email FROM client as c , reservation as r WHERE c.Cin = r.Cin GROUP BY c.Cin HAVING COUNT(*) >= 2;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.conn);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            DataTable tab = dt.Tables[0];
            liste_clients.DataSource = tab;
        }
        



        

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void liste_terrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prixTerr_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f2 = new Form7();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f2 = new Form9();
            f2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }
    }
}
