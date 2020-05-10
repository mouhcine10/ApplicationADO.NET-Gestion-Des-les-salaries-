using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gest
{
    public partial class utilisateur : Form
    {
        public string log, mdp;

        

        public utilisateur()
        {

            

            InitializeComponent();
        }
        BulltienDePaie b = new BulltienDePaie();
        connection c = new connection();

        private void utilisateur_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            connection c = new connection();
            c.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Program.cnx.Open();
            //Program.cmd.Connection = Program.cnx;
            //Program.cmd.CommandText = "select * from Bulltien as b , salarie as s  where b.matricule=s.matricule and datepaie= '" + dateTimePicker1.Value.Date.ToString()+"'";

            //Program.dr = Program.cmd.ExecuteReader();

            //DataTable dt = new DataTable();
            //dt.Load(Program.dr);

            //dataGridView1.DataSource = dt;
            //Program.dr.Close();
            //Program.cnx.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
     
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formulaire f = new Formulaire();

            f.Show();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            utilisateur u = new utilisateur();
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
