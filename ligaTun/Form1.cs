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
    public partial class Form1 : Form
    {
        
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lister_teraain();
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
        private void Lister_teraain()
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
            string sql = "select id_terrain ,nom , adresse from terrain";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.conn);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            DataTable tab = dt.Tables[0];
            liste_terrain.DataSource = tab;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (nomTerr.Text.Trim() == "" || addTerr.Text.Trim() == "" )
            {
                MessageBox.Show("Veulliez remplir tout les champs !!");
                nomTerr.Focus();
            }
            else
            {
                string sql = "INSERT INTO terrain (nom,adresse) VALUES ('" + nomTerr.Text.Trim() + "','" + addTerr.Text.Trim()+"')";
                MySqlCommand comm = new MySqlCommand(sql, this.conn);
                try
                {
                    int x = comm.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Insertion avec succes ");
                        nomTerr.Text = "";
                        addTerr.Text = "";
                        
                        Lister_teraain();
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
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (idTerr.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez selectionner un terrain !!");
            }
            else
            {
                string sql = "Update terrain set nom='"+nomTerr.Text.Trim()+"',adresse='"+addTerr.Text.Trim() +"'where id_terrain="+idTerr.Text.Trim();
                MySqlCommand cmd = new MySqlCommand(sql , this.conn );
                try
                {
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Modification avec succes ");
                        nomTerr.Text = "";
                        
                        addTerr.Text = "";
                        Lister_teraain();
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'insertion !!");
                    }
                }catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void liste_terrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTerr.Text = liste_terrain.CurrentRow.Cells[0].Value.ToString();
            nomTerr.Text=liste_terrain.CurrentRow.Cells[1].Value.ToString();
            addTerr.Text = liste_terrain.CurrentRow.Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (idTerr.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez selectionner un terrain !!");
            } else 
           if ( MessageBox.Show("Voullez vous supprimer ce terrain ?? ", "Supprimer" ,
               MessageBoxButtons.YesNo ,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sql = "DELETE FROM terrain where id_terrain="+idTerr.Text.Trim();
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                try
                {
                    int x =cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Suppression avec succes ");
                        nomTerr.Text = "";
                        addTerr.Text = "";
                        Lister_teraain();
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

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
