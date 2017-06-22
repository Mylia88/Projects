using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fonction2();
        }
        static int Division(int a,int b)
        {
            string s = "A";
            b = int.Parse(s);
            return a / b;

            // GESTION LOCALE DE L EXCEPTION
            //try
            //{
            //    return a / b;
            //}
            //catch( Exception ex1)
            //{
            //    Console.WriteLine("Exception Message : {0} \r\n Application : {1} Fonction : {2}", ex1.Message,
            //        ex1.Source, ex1.TargetSite);
            //    Console.ReadLine();
            //    return 0;
            //}
            

        }
        // GESTION GLOBALE
        static void Fonction2 ()
        {

            try
            {
                int resultat = Division(5,0);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("F2 Erreur Division 0 Message : {0} \r\n Application : {1} Fonction : {2}", ex1.Message,
                    ex1.Source, ex1.TargetSite);
                Console.ReadLine();
               
            }
            catch (ArithmeticException ex1)
            {
                Console.WriteLine("F2 Erreur Arithmétique autre que division 0 Message : {0} \r\n Application : {1} Fonction : {2}", ex1.Message,
                    ex1.Source, ex1.TargetSite);
                Console.ReadLine();
            }
            catch (Exception ex1)
            {
                Console.WriteLine("F2 Erreur autre Message : {0} \r\n Application : {1} Fonction : {2}", ex1.Message,
                    ex1.Source, ex1.TargetSite);
                Console.ReadLine();
            }
        }
    }
}
