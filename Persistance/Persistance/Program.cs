using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SalariesDll;


namespace Persistance
{
    class Program
    {
        static void Main(string[] args)
        {

            TesterSalariesXML();



        }

        static void TesterSalariesXML()
        {
            Salaries ListeSalaries = new Salaries();
            ListeSalaries.Add(new Salarie()
            {
                Matricule = "12XXX34",
                Nom = "Hemar",
                Prenom = "Mylene",
                DateNaissance = new DateTime(1988, 02, 20),
                SalaireBrut = 2000,
                TxCS = 0.20
            });
            ListeSalaries.Add(new Salarie("12XXX35", "Groot", "JeSAppelle", new DateTime(2000, 03, 19), 2500, 0.30));
            ListeSalaries.SaveXML(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            ListeSalaries.LoadXML(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            foreach (Salarie item in ListeSalaries)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
        static void TesterSalariesBinaire()
        {
            Salaries ListeSalaries = new Salaries();
            ListeSalaries.Add(new Salarie()
            {
                Matricule = "12XXX34",
                Nom = "Hemar",
                Prenom = "Mylene",
                DateNaissance = new DateTime(1988, 02, 20),
                SalaireBrut = 2000,
                TxCS = 0.20
            });
            ListeSalaries.Add(new Salarie("12XXX35", "Groot", "JeSAppelle", new DateTime(2000, 03, 19), 2500, 0.30));
            ListeSalaries.SaveBinary(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            ListeSalaries.LoadBinary(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            foreach (Salarie item in ListeSalaries)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
        static void TesterSalariesCVS()
        {
            Salaries ListeSalaries = new Salaries();
            ListeSalaries.Add(new Salarie()
            {
                Matricule = "12XXX34",
                Nom = "Hemar",
                Prenom = "Mylene",
                DateNaissance = new DateTime(1988,02,20),
                SalaireBrut = 2000,
                TxCS = 0.20
            });
            ListeSalaries.Add(new Salarie("12XXX35", "Groot", "JeSAppelle",new DateTime(2000,03,19),2500,0.30));
            ListeSalaries.SaveText(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            ListeSalaries.LoadText(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\Persistance");
            foreach (Salarie item in ListeSalaries)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }

        static void EcrireMots()
        {
            FileStream fs = new FileStream("DossierMots.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Mot1");
            sw.WriteLine("Mot2");
            sw.WriteLine("Mot3");


            string mot = Console.ReadLine();
            while (mot != "")
            {
                sw.WriteLine(mot);
                mot = Console.ReadLine();
            }

            sw.Close();
            fs.Close();
        }
        

    }
}
