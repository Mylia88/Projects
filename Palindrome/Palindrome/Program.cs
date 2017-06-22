using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mot = string.Empty;
            do
            {  
                     
            Console.WriteLine("Entrez un supposé palindrome :");
            Mot = Console.ReadLine();
            
            if (EstPalindrome(Mot))
            { 
            Console.WriteLine("Le mot {0} est un palindrome",Mot);
            }
            else
            {
                Console.WriteLine("Le mot {0} n'est pas un palindrome",Mot);
            }
                
                
            } while (Mot!=string.Empty);


        }
        static bool EstPalindrome(string Mot)
        {
            int i, j;

            for (i = 0, j = Mot.Length - 1; (i < j) && (Mot[i] == Mot[j]); i++, j--)
            {

            }

            return (i >= j);
        }
    }
}
