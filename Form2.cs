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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        
        

        

        private void maisAJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        DataTable dt = new DataTable();
        private void listeDesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void realiserBulltieanDePaieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
         
        private void listDesDemandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void listDesSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Salarie s = new Salarie();


            List_des_Salarie l = new List_des_Salarie();
            l.MdiParent = this;
            l.dataGridView1.Rows.Clear();
            l.dataGridView1.DataSource = s.Act("salarie");

            l.Show();

        }

        private void deconnectéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            connection c = new connection();
            c.Show();

        }

        private void creerUnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cree_un_compte c = new Cree_un_compte();
            c.MdiParent = this;
            c.Show();

        }

        private void listeDesDemandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try {

                LISTE_DES_CONGé l = new LISTE_DES_CONGé();

                l.MdiParent = this;


                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "select * from congé";
                Program.dr = Program.cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Program.dr);
                l.comboBox1.DataSource = dt;
                l.comboBox1.DisplayMember = "numCongé";

                Program.dr.Close();
                Program.cnx.Close();

                l.dataGridView2.DataSource = dt;

                l.Show();
            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            }



        private void réailserUnBulltienDePaieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulltienDePaie b = new BulltienDePaie();
            b.MdiParent = this;
            b.Show();
        }

        private void fIchierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
