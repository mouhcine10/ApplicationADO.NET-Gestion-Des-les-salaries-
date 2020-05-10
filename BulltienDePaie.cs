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
    public partial class BulltienDePaie : Form
    {
        public BulltienDePaie()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

          
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "insert into bulltien values(" + textBoxenfant.Text + "," + decimal.Parse(textBoxmh.Text) + "," + decimal.Parse(textBoxth.Text) + "," + decimal.Parse(textBoxprime.Text) + "," + int.Parse(textBoxMatricule.Text) + ")";

                Program.cmd.ExecuteNonQuery();


                //Program.cnx.Close();


                


                //    Program.cnx.Open();
                    Program.cmd.Connection = Program.cnx;
                    Program.cmd.CommandText = "select sb , cnss , ir, Allocation ,  SN  from bulltien  where Matricule =" + textBoxMatricule.Text;

                    Program.dr = Program.cmd.ExecuteReader();

                    if (Program.dr.Read())
                    {


                        textBoxsb.Text = Program.dr[0].ToString();
                        textBoxcnss.Text = Program.dr[1].ToString();
                        textBoxir.Text = Program.dr[2].ToString();
                        textBoxallo.Text = Program.dr[3].ToString();
                        textBoxsn.Text = Program.dr[4].ToString();




                    }


                    Program.cnx.Close();







                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                } 
            
            }

        

            









        

        private void textBoxth_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxmh_TextChanged(object sender, EventArgs e)
        {
           

            }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            Program.cnx.Open();

            Program.cmd.Connection = Program.cnx;
            Program.cmd.CommandText = "select nom , prenom ,sexe, datenaissance, dateEmbuche ,cin,sitiationfami,grade, echel from salarie where matricule= " + int.Parse(textBoxMatricule.Text);

            Program.dr = Program.cmd.ExecuteReader();

            if (Program.dr.Read())
            {
                textBox_nom.Text = Program.dr[0].ToString();
                textBoxprenom.Text = Program.dr[1].ToString();
                textBoxsexe.Text = Program.dr[2].ToString();
                textBoxdn.Text = Program.dr[3].ToString();
                textBoxde.Text = Program.dr[4].ToString();
                textBoxCIN.Text = Program.dr[5].ToString();
                textBoxsf.Text = Program.dr[6].ToString();
                textBoxgrade.Text = Program.dr[7].ToString();
                textBoxechel.Text = Program.dr[8].ToString();






            }
        
            
    Program.cnx.Close();

        }
    }
}
