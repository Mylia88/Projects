using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;
using System.Collections;

namespace LesCollections
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Salaries listeSalaries = new Salaries();
             listeSalaries.Add(new Salarie() { Matricule = "12abc34", Nom = "JeSAppelle", Prenom = "groot" });
             listeSalaries.Add(new Salarie() { Matricule = "12abc35", Nom = "JeSAppelle1", Prenom = "groot1" });
             listeSalaries.Add(new Salarie() { Matricule = "12abc34", Nom = "JeSAppelle", Prenom = "groot" });
             Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);
             Salarie salASupprimer = listeSalaries.Extraire("12abc35");
             listeSalaries.Remove(salASupprimer);
             Console.WriteLine("Attendu true {0}", 1 == listeSalaries.Count);
             listeSalaries.Remove("12abc34");
             Console.WriteLine("attendu true {0}", 0 == listeSalaries.Count);

             Console.ReadLine();
         }*/
            SalariesHS listeSalaries = new SalariesHS();
            listeSalaries.Add(new Salarie() { Matricule = "12abc34", Nom = "JeSAppelle", Prenom = "groot" });
            listeSalaries.Add(new Salarie() { Matricule = "12abc35", Nom = "JeSAppelle1", Prenom = "groot1" });
            listeSalaries.Add(new Salarie() { Matricule = "12abc34", Nom = "JeSAppelle", Prenom = "groot" });
            Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);
            Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);
            Console.WriteLine("attendu true {0}", 2 == listeSalaries.Count);


            Console.ReadLine();
        }


    } 
       
}

