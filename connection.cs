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
    public partial class connection : Form
    {
                public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
           
            try
            {
                utilisateur u = new utilisateur();


                Program.cnx.Open();

                Program.cmd.Connection = Program.cnx;

                Program.cmd.CommandText = "select loginsal ,motdepasse ,grade from salarie where  loginsal ='" + textBox_login.Text + "' and  motdepasse='" + textBoxmotpasse.Text + "' and grade ='manager' ";


                Program.dr = Program.cmd.ExecuteReader();

                

                if (Program.dr.Read() )
                {

                    Form2 f2 = new Form2();


        
                    f2.Show();


                    this.Hide();

                  

                }


                Program.cnx.Close();

                utilisateur u1 = new utilisateur();
                Program.cnx.Open();

                Program.cmd.Connection = Program.cnx;

                Program.cmd.CommandText = "select loginsal , motdepasse , grade from salarie where  loginsal ='" + textBox_login.Text + "' and  motdepasse='" + textBoxmotpasse.Text + "' and grade='salarie'";


                Program.dr = Program.cmd.ExecuteReader();
                if (Program.dr.Read())
                {
                    
                    u1.Show();

                    this.Hide();
             

                }

                Program.cnx.Close();


                u1.dataGridView1.Visible = true;


                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "select nom, prenom , sexe , sitiationfami as sitiationfamilial , servis , echel , grade , nbrenfant as 'nomber enfant' , mh as 'masse horaire' , th as 'taux horaire' ,sb as 'salarie de basse' , cnss  , Ir ,Allocation , prime , sn as 'salaire Net' from salarie as s , bulltien as b where s.matricule = b.matricule  and  (s.loginsal='" + textBox_login.Text + "'  and s.motdepasse ='" + textBoxmotpasse.Text + "')";
                Program.dr = Program.cmd.ExecuteReader();



                DataTable dt = new DataTable();

                dt.Load(Program.dr);
                Program.dr.Close();
                Program.cnx.Close();
                u1.dataGridView1.DataSource = dt;


                u1.dataGridView2.Visible = true;
                connection c = new connection();


                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "select  numcongé , nom, prenom , sexe , typecongé ,datedebut , datfin , nomb as 'nomner des jours' ,etat  from salarie as s , congé as c where s.matricule = c.matricule  and  (s.loginsal='" + textBox_login.Text + "'  and s.motdepasse ='" + textBoxmotpasse.Text + "')";
                Program.dr = Program.cmd.ExecuteReader();

                DataTable dt1 = new DataTable();
                
                dt1.Load(Program.dr);
                Program.dr.Close();
                Program.cnx.Close();
                u1.dataGridView2.DataSource = dt1;





            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("voulez vous supprimer", "validation",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {


                this.Close();
            }
            


        }
    }
}
