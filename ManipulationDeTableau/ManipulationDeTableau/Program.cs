using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationDeTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static int[] AppelTableau()
        {
            int[]Tab = new int [10];
            int TTab = Tab.Length;
            Random Aleatoire = new Random();
            for (int i = 0; i < TTab; i++)
            {
                Tab[i]=Aleatoire.Next(0,101);
            }
            AffichageTableau(Tab);
            Console.ReadLine();

            return Tab;
        }
        static void AffichageTableau(int []Tab)
        {
            foreach (int i in Tab)
            {
                Console.Write("{0} ", i);

            }
            Console.WriteLine();
            
        }
        static void Menu()
        {
            Console.WriteLine("Tapez B pour effectuer le tri Bulle");
            Console.WriteLine("Tapez C pour effectuer le tri par Comptage");
            Console.WriteLine("Tapez P pour effectuer le tri par Permutation");
            Console.WriteLine("Tapez S pour effectuer le tri par Sélection");
            Console.WriteLine("\nTapez F pour sortir du programme");

            string ChoixMenu;

            do
            {           
            Console.WriteLine("\nQuel est votre choix ?");
            ChoixMenu = Console.ReadLine().ToUpper();


                switch (ChoixMenu)
                {
                    case "B":
                        TriBulle();
                        break;
                    case "C":
                        TriComptage();
                        break;
                    case "P":
                        TriPermutation();
                        break;
                    case "S":
                        TriSelection();
                        break;
                    case "F":
                        FinProgramme();
                        break;
                    default:                        
                        Console.WriteLine("Saisie incorrecte !");
                        break;
                }
            } while ((ChoixMenu != "B") && (ChoixMenu != "C") && (ChoixMenu != "P") && (ChoixMenu != "S") && (ChoixMenu != "F"));
               

        }

        static void TriBulle()
        {
            int[] Tab = AppelTableau();
            int TTab = Tab.Length;      
            bool Permut = false;
            do
            {
                Permut = false;
                for (int i = 0;i<TTab-1; i++)
                {
                    if (Tab[i] > Tab[i+1])
                    {
                        int Tamp = Tab[i];
                        Tab[i] = Tab[i + 1];
                        Tab[i + 1] = Tamp;
                        Permut = true;
                        AffichageTableau(Tab);
                    }
                }
            } while (Permut == true);
            Console.ReadLine();
            FinProgramme();
        }
        static void TriComptage()
        {

        }

        static void TriPermutation()
        {
            int[] Tab = AppelTableau();
            int TTab = Tab.Length;
            for (int i = 0; i < TTab - 1; i++)
            {
                if (Tab[i]>Tab[i+1])
                {
                    int Tamp = Tab[i + 1];
                    int PosTamp = i + 1;
                    do
                    {
                        Tab[PosTamp] = Tab[PosTamp - 1];
                        PosTamp = PosTamp - 1;
                        if (PosTamp == 1)
                        {
                            bool Stop = false;
                        }
                            else
                            {

                            }
                        

                    } while (Stop == false);
                }
                AffichageTableau(Tab);
            }
            Console.ReadLine();
            FinProgramme();
        }

        static void TriSelection()
        {
            int[] Tab = AppelTableau();
            int TTab = Tab.Length;

            for (int i = 0; i < TTab - 1; i++)
            {
                int Mini = Tab[i];
                int PosMin = i;
                for (int j = i + 1; j < TTab; j++)
                {
                    if (Tab[j] < Mini)
                    {
                        Mini = Tab[j];
                        PosMin = j;
                    }
                }
                while (PosMin > i)
                {
                    Tab[PosMin] = Tab[PosMin - 1];
                    PosMin = PosMin - 1;
                }
                Tab[i] = Mini;
                AffichageTableau(Tab);
            }
            Console.ReadLine();
            FinProgramme();
        }

        static void FinProgramme()
        {
            Console.WriteLine("Appuyez sur une touche");
            Console.ReadLine();
        }

    }
}
