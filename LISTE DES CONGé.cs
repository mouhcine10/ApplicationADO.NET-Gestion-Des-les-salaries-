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
    public partial class LISTE_DES_CONGé : Form
    {
        public LISTE_DES_CONGé()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {








        }

        private void button2_Click(object sender, EventArgs e)
        {

            formulair2 f = new formulair2();
            try
            {
                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "select numCongé , Nom , Prenom , nomb from  congé as c  , salarie as s where c.matricule = s.matricule and numCongé=" + comboBox1.Text;

                Program.dr = Program.cmd.ExecuteReader();

                if (Program.dr.Read())
                {
                    f.Show();

                    f.textBox1.Text = Program.dr[0].ToString();

                    f.textBox2.Text = Program.dr[1].ToString();

                    f.textBox3.Text = Program.dr[2].ToString();

                    f.textBox4.Text = Program.dr[3].ToString();


                }

                
                Program.dr.Close();
                Program.cnx.Close();

                Salarie S = new Salarie();
              
                dataGridView2.DataSource = S.Act("Congé");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "delete from congé where numCongé =" + comboBox1.SelectedItem;
                Program.cmd.ExecuteNonQuery();
                Program.cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //}
            }
        }


    }
}
    









                    
            
    
     
