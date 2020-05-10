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
    public partial class List_des_Salarie : Form
    {
        public List_des_Salarie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cree_un_compte c = new Cree_un_compte();
            c.Show();
        }

        private void List_des_Salarie_Load(object sender, EventArgs e)
        {

        }
    }
}
