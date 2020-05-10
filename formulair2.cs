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
    public partial class formulair2 : Form
    {
        public formulair2()
        {
            InitializeComponent();
        }

        string etet= "resvoire";
        string etet1 = "";
        private void button1_Click(object sender, EventArgs e)
        { 


            try {

                 string etet1 = "accpté";
                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "update  congé  set  etat='"+etet1+"' where  numCongé=" + textBox1.Text ;
                Program.cmd.ExecuteNonQuery();
                Program.cnx.Close();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try {
                etet1 = "refusé";

                Program.cnx.Open();
                Program.cmd.Connection = Program.cnx;
                Program.cmd.CommandText = "update  congé   set  etat='"+etet1+"' where  numCongé="+textBox1.Text ;
                Program.cmd.ExecuteNonQuery();
                Program.cnx.Close();
                this.Hide();
            } catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
