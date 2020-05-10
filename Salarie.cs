        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gest
{
    class Salarie
    {
        public string matricule;
        public string CIN;
        public string nom;
        public string prenom;
        public string sexe;
        public DateTime date_naissance;
        public string adresse;

        public string situation_familiale;
        public string site;
        public string Service;
        public DateTime date_embuche;

        public int echel;

        public double masse_h;
        public double taux_h;

        public double prime;

        public int mbr_enfant;

        public string login;
        public string mdp;



        //Salarie s = new Salarie(textBox_matricule.Text, int.Parse(textBox_cin.Text), textBoxNom.Text, textBox_prenom.Text, se, dateTimePicker_datenass.Value, textBoxAdress.Text, comboBox1.SelectedText, comboBox_Site.SelectedText, comboBox_service.SelectedText, dateTimePicker_dateembuche.Value, comboBox_echel.SelectedIndex, double.Parse(textBox_mh.Text), int.Parse(textBox_th.Text), double.Parse(textBox_prim.Text), int.Parse(textBox_nbrenfant.Text), dateTimePicker1.Value);

        public Salarie() { }








        public Salarie(string m, string cin, string n, string p, string s, DateTime dn, string ad, string sf, string si, string ser, DateTime d_e, int ech, double mh, double th, double pr, int nb)
        {

            this.matricule = m;
            this.CIN = cin;
            this.nom = n;
            this.prenom = p;
            this.sexe = s;
            this.date_naissance = dn;
            this.adresse = ad;
            this.situation_familiale = sf;
            this.site = si;
            this.Service = ser;
            this.date_embuche = d_e;
            this.echel = ech;
            this.masse_h = mh;
            this.taux_h = th;
            this.prime = pr;
            this.mbr_enfant = nb;

        }

        public Salarie(double mh, double th)
        {
            this.masse_h = mh;
            this.taux_h = th;

        }


        public double SalaireBase()
        {

            return masse_h * taux_h;

        }


        public double CalculerRCNSS(double SB)
        {
            double re = 0;


            if (SB >= 6000)
            {
                re = (6000 * 4.9) / 100;


            }
            else { re = (SB * 4.29) / 100; }



            return re;

        }


        public double CalculerIR(double SB)
        {
            double ir = 0;

            if (SB <= 2500)
            {

                ir = 0;

            }
            else if (SB >= 2501 || SB <= 4166)
            {


                ir = (SB * 10) / 100;


            }
            else if (SB >= 4167 || SB <= 5000)
            {

                ir = (SB * 20) / 100;

            }
            else if (SB >= 5001 || SB <= 6666)
            {

                ir = (SB * 30) / 100;

            }
            else if (SB >= 6667 || SB <= 15000)
            {

                ir = (SB * 34) / 100;


            }
            else if (SB >= 15001)
            {

                ir = (SB * 38) / 100;

            }




            return ir;
        }


        public decimal AllocationFamiliale(int nbr_enfant)
        {
            decimal som = 200, som2 = 36, all = 0;


            if (nbr_enfant == 1)
            {

                all = som;

            }
            else if (nbr_enfant == 2)
            {
                all = som * 2;


            }
            else if (nbr_enfant == 3)
            {

                all = som * 3;

            }
            else if (nbr_enfant == 4)
            {

                all = (som * 3) + som2;


            }
            else if (nbr_enfant == 5)
            {

                all = (som * 3) + (som2 * 2);

            }
            else if (nbr_enfant == 6)
            {

                all = (som * 3) + (som2 * 3);


            }
            else if (nbr_enfant >= 7)
            {

                all = 708;


            }

            return all;

        }



        public double SalarieNet()
        {
            double sn, n = 0;
            n = CalculerIR(SalaireBase()) + CalculerRCNSS(SalaireBase());

            sn = SalaireBase() - n;

            sn = sn + prime;

            return sn;

        }






        public DataTable Act( string  table)
        {
            DataTable dt = new DataTable();

            Program.cnx.Open();


            Program.cmd.Connection = Program.cnx;

            Program.cmd.CommandText = "select * from "+table ;
        
            Program.dr = Program.cmd.ExecuteReader();

            dt.Load(Program.dr);







            Program.dr.Close();

            Program.cnx.Close();






            return dt;





        }







    }
}



