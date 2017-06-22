using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correction
{
    class Program
    {
        static void Main(string[] args)
        {
            string origine;
            string recherche;
            origine = "Mon petit chien est une beau chien roux.";
            recherche = "chien";
            int occurrences = compterOccurrences(origine, recherche);
            origine = string.Empty;

        }

        private static int compterOccurrences(string origine)
        {
            int nbrOccurrences = 0;
            int pos = 0;
            while (pos != -1)
            {
                pos = origine.IndexOf(recherche, pos);
                if(pos!=-1)
                {
                    nbrOccurrences++;
                    pos += recherche.Length;
                }

            }
        }
        return nbrOccurrences;

            private static string remplaceFirst(string origine, string recherche, string remplacement)
    }
}
