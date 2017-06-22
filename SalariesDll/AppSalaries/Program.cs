using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;


namespace AppSalaries
{
    class SalarieTest
    {
        static void Main(string[] args)
        {
            Salarie GrootParfait = new Salarie()
            {
                Matricule = "12acb34",
                Nom = "Hemar",
                Prenom = "Mylene",
                SalaireBrut = 1000,
                TxCS = 0.35,
                DateNaissance = new DateTime(1988, 02, 20)

            };

            Commercial GrootCommercial = new Commercial()
            {
                Matricule = "12acb34",
                Nom = "Hemar",
                Prenom = "Mylene",
                SalaireBrut = 1000,
                TxCS = 0.35,
                DateNaissance = new DateTime(1988, 02, 20),
                ChiffreAffaire = 100000,
                Commission = 0.15,
            };


            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n",GrootParfait.Matricule,GrootParfait.Nom,
                GrootParfait.Prenom,GrootParfait.DateNaissance,GrootParfait.SalaireBrut,GrootParfait.TxCS,
                GrootParfait.SalaireNet);
            Console.WriteLine(GrootCommercial);
            Console.ReadLine();

            
        }
    }
}
