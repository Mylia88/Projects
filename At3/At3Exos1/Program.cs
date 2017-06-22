using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At3
{
    class Program
    {

        static void Main(string[] args)
        {
            Dialogue();
        }
        static void Dialogue()
        {
            Exos1();
            Exos2();
            Exos3();
            Exos4();
            Exos5();
            Exos5b();
            Exos6();
            Exos7();
            Exos7b();
            Exos8();


        }
        static void Exos1()
        {
            Console.WriteLine("Exos1");
            string entier = "";
            Console.WriteLine("Veuillez entrer un nombre entier");
            entier = Console.ReadLine();

            int a = int.Parse(entier);
            short b = (short)a++;
            long c = ++a;
            Console.WriteLine("a = {0}, b = {1} et c = {2}", a, b, c);
            Console.WriteLine("La conversion implicite est la conversion c. Nous passons d'un type petit à un type plus grand.\nIl n'y a donc pas de perte de données.");
            Console.ReadLine();
        }

        static void Exos2()
        {
            Console.WriteLine("Exos2");
            int a = 0, b = 0;
            a = 5;
            b = a;
            b = b + 5;
            Console.WriteLine("a={0}, b={1}", a, b);

            int[] tabA, tabB;
            tabA = new int[3] { 2, 5, 4 };
            tabB = tabA;
            tabB[0] = 1;
            Console.WriteLine("tabA = {0}, tabB = {1}", tabA[0], tabB[0]);
            Console.WriteLine("Etant donné que tabA a été assigné à tabB, la valeurs 1 est modifiée dans les 2 tableaux.");
            Console.ReadLine();
        }
        private static void Exos3()
        {
            Console.WriteLine("Exos3");
            int s = 3;
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
            modifierValeur(s);
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", s);
            Console.WriteLine("La modification de valeur n'a pas eu lieu.");
            Console.ReadLine();
        }
        private static void modifierValeur(int o)
        {
            o = 4;
        }
        private static void Exos4()
        {
            Console.WriteLine("Exos4");
            int s = 3;
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
            modifierValeurReference(ref s);
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", s);
            Console.WriteLine("On obtient bien une modification de valeur.");
            Console.WriteLine("Pour modifier une valeur par appel de fonction on se doit d'utiliser une référence.");
            Console.ReadLine();
        }
        private static void modifierValeurReference(ref int p)
        {
            p = 4;
        }

        private static void Exos5()
        {
            Console.WriteLine("Exos5");
            int[] tabS = new int[3] { 1, 4, 6 };
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", tabS[0]);
            modifierTabValeur(tabS);
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", tabS[0]);
            Console.WriteLine("Le changement de valeur a bien lieu.");
            Console.ReadLine();

        }

        private static void modifierTabValeur(int[] tabO)
        {
            tabO[0] = 8;
        }

        private static void Exos5b()
        {
            Console.WriteLine("Exos5b");
            int[] tabS = new int[3] { 1, 4, 6 };
            Console.WriteLine("Valeur avant appel méthode modification valeur {0},{1}", tabS[0], tabS[1]);
            modifierTabValeur2(tabS);
            Console.WriteLine("Valeur après appel méthode modification valeur {0},{1}", tabS[0], tabS[1]);
            Console.ReadLine();
        }

        private static void modifierTabValeur2(int[] tabO)
        {
            tabO[0] = 8;
            tabO = new int[] { 9, 10, 11 };
        }

        private static void Exos6()
        {
            Console.WriteLine("Exos6");
            int[] tabS = new int[3] { 1, 4, 6 };
            Console.WriteLine("Valeur avant appel méthode modification valeur {0},{1}", tabS[0], tabS[1]);
            modifierTabValeur3(ref tabS);
            Console.WriteLine("Valeur après appel méthode modification valeur {0},{1}", tabS[0], tabS[1]);
            Console.WriteLine("On constate que cette foi-ci les valeurs ont bien été modifiées.");
            Console.WriteLine("");
            Console.ReadLine();
        }

        private static void modifierTabValeur3(ref int[] tabO)
        {
            tabO[0] = 8;
            tabO = new int[] { 9, 10, 11 };
        }

        static void Exos7()
        {
            Console.WriteLine("Exos7");
            string a = "Aurevoir", b = "Bonjour";
            Console.WriteLine("Valeur avant appel méthode modification valeur : {0}, {1}", a, b);
            modifierChaValeur(a, b);
            Console.WriteLine("Valeur après appel méthode modification valeur : {0}, {1}", a, b);
            Console.ReadLine();

        }

        static void modifierChaValeur(string a, string b)
        {
            string x = a;
            a = b;
            b = x;
        }

        static void Exos7b()
        {
            Console.WriteLine("Exos7b");
            string a = "Aurevoir", b = "Bonjour";
            Console.WriteLine("Valeur avant appel méthode modification valeur : {0}, {1}", a, b);
            modifierChaValeur(ref a, ref b);
            Console.WriteLine("Valeur après appel méthode modification valeur : {0}, {1}", a, b);
            Console.WriteLine("Le permutation est possible par référence, mais pas par valeur.");
            Console.ReadLine();
        }

        static void modifierChaValeur(ref string a, ref string b)
        {
            string x = a;
            a = b;
            b = x;  
        }

        static void Exos8()
        {
            Console.WriteLine("Exos8");
            Console.WriteLine("Entrez une valeur");
            string saisie = Console.ReadLine();
            int a = Convert.ToInt32(saisie);
            int b = 0;
            if (TryDiv(a, out b))
            {
                Console.WriteLine("La valeur est paire !");
            }
            else
            {
                Console.WriteLine("La valeur est impaire !");
            }
            Console.ReadLine();

        }

        static bool TryDiv(int a, out int b)
        {
            if (a%2 == 0)
            {
                b = a / 2;
                return true;
            }
            else
            {
                b = 0;
                return false;
            }
        } 

        }


    }


