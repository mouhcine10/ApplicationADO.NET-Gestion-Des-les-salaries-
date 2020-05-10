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
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                Program.cnx.Open();


                Program.cmd.Connection = Program.cnx;

                string st = "resvoire";

                Program.cmd.CommandText = "insert into congé values ('" + comboBox_typec.SelectedItem + "','" + dateTimePicker_debut.Value.Date.ToString() + "','" + dateTimePicker_fin.Value.Date.ToString() + "','"+st+"',"+int.Parse(textBoxmatricule.Text)+")";
                    

                Program.cmd.ExecuteNonQuery();

                Program.cnx.Close();






                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }

        private void dateTimePicker_debut_ValueChanged(object sender, EventArgs e)
        {
            DateTime deb = DateTime.Parse(this.dateTimePicker_debut.Text);
            DateTime fin = DateTime.Parse(this.dateTimePicker_fin.Text);
            TimeSpan Diff = fin - deb;
            this.textBox1.Text = Diff.TotalDays.ToString();

        }

        private void dateTimePicker_fin_ValueChanged(object sender, EventArgs e)
        {
            DateTime debut = DateTime.Parse(this.dateTimePicker_debut.Text);
            DateTime fin = DateTime.Parse(this.dateTimePicker_fin.Text);
            TimeSpan Diff = fin - debut;
            this.textBox1.Text = Diff.TotalDays.ToString();

        }

        private void textBoxmatricule_TextChanged(object sender, EventArgs e)
        {
          
            try {
                     Program.cnx.Open();

                    Program.cmd.Connection = Program.cnx;

                
                

                    Program.cmd.CommandText = "select nom , prenom ,sexe, sites from salarie  where matricule=" + int.Parse(textBoxmatricule.Text);
                    Program.dr = Program.cmd.ExecuteReader();


                    if (Program.dr.Read())
                        textBox_Nom.Text = Program.dr[0].ToString();
                    textBox_prenom.Text = Program.dr[1].ToString();

                    if (Program.dr[2].ToString() == "m")
                    {

                        radioButton1_H.Checked = true;

                    }
                    else
                    {
                        radioButton_F.Checked = true;
                    }
                    comboBox_site.Text = Program.dr[3].ToString();


                    
                
                Program.cnx.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);            }
        }

        private void Formulaire_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
