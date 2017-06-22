using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesDll
{
    [Serializable()]
    public class Commercial : Salarie
    {
        private double _chiffreAffaire;
        private double _commission;
        public override double SalaireNet
        {
            get
            {
                return base.SalaireNet + (Commission * ChiffreAffaire);
            }
        }

        public double ChiffreAffaire
        {
            get
            {
                return _chiffreAffaire;
            }

            set
            {
                _chiffreAffaire = value;
            }
        }

        public double Commission
        {
            get
            {
                return _commission;
            }

            set
            {
                _commission = value;
            }
        }

        //Constructeur par défaut
        public Commercial() : base()
        {

        }

        //Constructeur
        public Commercial(string matricule, string nom, string prenom) : base(matricule, nom, prenom)
        {

        }

        //Constructeur de recopie
        public Commercial(Commercial Commercial1) : base(Commercial1)
        {
            this.ChiffreAffaire = Commercial1.ChiffreAffaire;
            this.Commission = Commercial1.Commission;
        }

        public override string ToString()
        {
            return string.Format("{0}\n ", base.ToString());
        }


    }
}
