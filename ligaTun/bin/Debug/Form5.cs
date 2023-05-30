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
    public partial class Form5 : Form
    {
        
        MySqlConnection conn;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lister_admins();
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
            Form1 f1 = new Form1();
            f1.Show();
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
        private void Lister_admins()
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
            string sql = "select idRes,Cin,nom,nbPersonnes,status,dtTakwira,RechercheBlassa from reservation as r , terrain as t where (t.id_terrain=r.idTerrain)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.conn);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            DataTable tab = dt.Tables[0];
            liste_reservation.DataSource = tab;
        }
        /*private void button5_Click(object sender, EventArgs e)



        { 
                string sql = "";
                    MySqlCommand comm = new MySqlCommand(sql, this.conn);
                try
                {
                    int x = comm.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Insertion avec succes ");
                        
                        Lister_admins();
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'insertion !!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/



        

        private void button6_Click(object sender, EventArgs e)
        {
            
        
               
            }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void liste_terrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRes.Text = liste_reservation.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = liste_reservation.CurrentRow.Cells[4].Value.ToString();
        }

        /*private void button7_Click(object sender, EventArgs e)
        {
             
           if ( MessageBox.Show("Voullez vous supprimer ce Admin ?? ", "Supprimer" ,
               MessageBoxButtons.YesNo ,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sql = "";
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                try
                {
                    int x =cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Suppression avec succes ");
                        
                        
                        Lister_admins();
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression !!");
                    }
                }
                catch(MySqlException ex) {
                    MessageBox.Show(ex.Message);
                }
            } 

        }*/

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

        private void button6_Click_1(object sender, EventArgs e)
        {
            string sql = "update reservation set status='"+comboBox1.Text.Trim()+"'where idRes="+idRes.Text.Trim();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            try
            {
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Modification avec succes ");

                    Lister_admins();
                }
                else
                {
                    MessageBox.Show("Erreur d'insertion !!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
        }
    }
}
