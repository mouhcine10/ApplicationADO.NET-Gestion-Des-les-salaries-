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
    public partial class Cree_un_compte : Form
    {
        public Cree_un_compte()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("etes vous sur supprimer cette Salarie" + MessageBoxIcon.Question + MessageBoxButtons.YesNo, "suppristion");


            if (dr == DialogResult.Yes)
            {


                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "delete from salarie where matricule=" + textBox_matricule.Text;

                Program.cmd.ExecuteNonQuery();
                Program.cnx.Close();

                MessageBox.Show("le Salarie supprimer"+MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sexe;

            try
            {
                Salarie S = new Salarie();


                if (radioButton_homme.Checked == true)
                {
                    sexe = "m";

                }
                else
                {
                    sexe = "f";
                }

                Program.cnx.Open();

                Program.cmd.Connection = Program.cnx;

                Program.cmd.CommandText = "insert into salarie values(" + int.Parse(textBox_matricule.Text) + ",'" + textBox_cin.Text + "','" + textBoxNom.Text + "','" + textBox_prenom.Text + "','" + sexe + "','" + dateTimePicker_datenass.Value.Date.ToString() + "','" + textBoxAdress.Text + "','" + dateTimePicker_dateembuche.Value.Date.ToString() + "','" + comboBox1.SelectedItem + "','" + comboBox_Site.SelectedItem + "','" + comboBox_service.SelectedItem + "'," + comboBox_echel.SelectedItem + ",'" + comboBoxGRADE.SelectedItem + "','" + textBoxLOGIN.Text + "','" + textBoxmodpas.Text + "')";
                Program.cmd.ExecuteNonQuery();


                Program.cnx.Close();



                MessageBox.Show("bien");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);







            }
        }






            
        

    private void button2_Click(object sender, EventArgs e)
        {
            try {
                string sexe;

                if (radioButton_homme.Checked == true)
                {
                    sexe = "m";

                }
                else
                {
                    sexe = "f";
                }


                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "update Salarie set cin='" + textBox_cin.Text + "', nom='" + textBoxNom.Text + "',' prenom='" + textBox_prenom.Text + "', sexe'" + sexe + "',datenaissance='" + dateTimePicker_datenass.Value.Date.ToString() + "',Adresse='" + textBoxAdress.Text + "',dateEmbuche='" + dateTimePicker_dateembuche.Value.Date.ToString() + "', sitiationfami='" + comboBox1.SelectedItem + "',sites='" + comboBox_Site.SelectedItem + "',servis='" + comboBox_service.SelectedItem + "',echel=" + comboBox_echel.SelectedItem + ",grade='" + comboBoxGRADE.SelectedItem + "',loginsal='" + textBoxLOGIN.Text + "',motdepasse='" + textBoxmodpas.Text + "' where matricule=" + textBox_matricule.Text;

            }catch(Exception ex) { MessageBox.Show(ex.Message);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
             


            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Cree_un_compte_Load(object sender, EventArgs e)
        {

        }
    }
}
