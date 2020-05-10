using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace gest
{
    static class Program
    {
        
        public static SqlConnection cnx =  new SqlConnection(@"Data Source=desktop-nfoh16m\sqlexpress;Initial Catalog=GestionDESSlarie;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;

        
           


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new connection());
        }
    }
}
