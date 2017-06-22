using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;

namespace LesCollections
{
    public class Salaries : List<Salarie>
    {
        public new void Add(Salarie salarie)
        {
           // if(ifExists(salarie))
           // {
             //   base.Add(salarie);
            //}
            //Méthode inutile car fonctionnalité implémentée par Contains
            if(!Contains(salarie))
            {
                base.Add(salarie);
            }
        }

        private bool ifExists(Salarie sal)
        {
            foreach (Salarie item in this)
            {
                if(item.Equals(sal))
                {
                    return true;
                }
            }
            return false;
        }

        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule == matricule)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));
        }


    }

    public class SalariesHS:HashSet<Salarie>
    {

    }
}
