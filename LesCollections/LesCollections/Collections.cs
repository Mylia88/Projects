using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;
using System.Collections;

namespace LesCollections
{
    class Collections
    {

        public static ArrayList CreerListeHeteroclite()
        {
            ArrayList listeObjets = new ArrayList();
            listeObjets.Add(20.5);
            listeObjets.Add(16);
            listeObjets.Add("Hello");

            Salarie salarie1 = new Salarie();
            salarie1.Nom = "JeSAppelle";
            salarie1.Prenom = "Groot";
            salarie1.DateNaissance = DateTime.Parse("20/02/1988");
            listeObjets.Add(salarie1);

            Commercial commercial1 = new Commercial();
            commercial1.Nom = "JeSeReAppelle";
            commercial1.Prenom = "Groot";
            commercial1.SalaireBrut = 2000;
            commercial1.TxCS = 10;
            commercial1.ChiffreAffaire = 100000;
            commercial1.Commission = 0.20;
            listeObjets.Add(commercial1);

            return listeObjets;
        }

        public static void AfficherListe(ArrayList listeObjets)
        {
            foreach (object Objet in listeObjets)
            {
                if(Objet.GetType() == typeof(double))
                {
                    Console.WriteLine("{0} est un double.", Objet.ToString());
                }
                if(Objet.GetType() == typeof(int))
                {
                    Console.WriteLine("{0} est un entier.", Objet.ToString());
                }
                if(Objet.GetType() == typeof(string))
                {
                    Console.WriteLine("{0} est une chaine.", Objet.ToString());
                }
                if(Objet.GetType() == typeof(Salarie))
                {
                    Console.WriteLine("{0} est un salarié.", Objet.ToString());
                }
                if(Objet.GetType() == typeof(Commercial))
                {
                    Console.WriteLine("{0} est un commercial.", Objet.ToString());
                }

            }
        }
    }   
}


