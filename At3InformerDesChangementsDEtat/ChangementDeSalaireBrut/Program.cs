using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;


namespace ChangementDeSalaireBrut
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie salTest = new Salarie("12XXX34", "JeSapelle", "Groot");
            salTest.SalaireBrut = 1800;
            
            salTest.ChangementSalaire += new EventHandler<ChangementSalaireEventArgs>(salarie_changementSalaire);
            Console.ReadLine();
            salTest.SalaireBrut = 3600;
            Console.ReadLine();
        }
        static void salarie_changementSalaire(Object sal, ChangementSalaireEventArgs e)
        {
            double txAugment = ((e.NouveauSalaire - e.AncienSalaire) / e.AncienSalaire)*100;
            Console.WriteLine("Ancien salaire {0}, nouveau salaire {1}, taux augmentation {2}%",e.AncienSalaire, e.NouveauSalaire,txAugment);
        }
    }
}
