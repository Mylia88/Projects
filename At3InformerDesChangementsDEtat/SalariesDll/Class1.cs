using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesDll
{
    public class Salarie
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private double _salaireBrut;
        private double _txCS;
        private DateTime _dateNaissance;
        public static int CompteurInst = 0;
        public event EventHandler<ChangementSalaireEventArgs> ChangementSalaire;

        public string Matricule
        {
            get
            {
                return _matricule;
            }

            set
            {
                if ( isMatValide(value))
                _matricule = value;
            }
        }

        public string Nom
        {
            get
            
            {
                return _nom;
            }

            set
            {
                if (isNomPrenomValide(value))
                    _nom = string.Format("{0}{1}", value.Trim().Substring(0, 1).ToUpper(),
                    value.Trim().Substring(1, value.Trim().Length - 1).ToLower());
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                if (isNomPrenomValide(value))
                    _prenom = string.Format("{0}{1}", value.Trim().Substring(0, 1).ToUpper(),
                    value.Trim().Substring(1, value.Trim().Length - 1).ToLower());                   
            }
        }

        public double SalaireBrut
        {
            get
            {
                return _salaireBrut;
            }

            set
            {
                if (_salaireBrut != value)
                    OnChangementSalaire(this, new ChangementSalaireEventArgs(this._salaireBrut, value));
                this._salaireBrut = value;
            }
        }
        //Délégué
        private void OnChangementSalaire(Salarie salarie, ChangementSalaireEventArgs changementSalaireEventArgs)
        {
            if (ChangementSalaire != null) ChangementSalaire(salarie, changementSalaireEventArgs);
        }



     
        public double TxCS
        {
            get
            {
                return _txCS;
            }

            set
            {
                if (isTauxValide(value))
                    _txCS = value;
            }
        }

        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }

            set
            {
                if (isDateValide(value))
                    _dateNaissance = value;
            }
        }

        public virtual double SalaireNet
        {
            get
            {
                return _salaireBrut - (_salaireBrut * _txCS);
            }
        }

        private static bool isNomPrenomValide(string valeur)
        {
            if (valeur == null || valeur.Trim().Length < 3 || valeur.Length > 30)
                return false;
            foreach (Char c in valeur)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private static bool isTauxValide(double fourcheTaux)
        {
            return (fourcheTaux >= 0 && fourcheTaux <= 0.60);                
        }
        
        private static bool isDateValide(DateTime dNaissance)
        {
            return (dNaissance >= new DateTime(1900, 01, 01) && dNaissance <= DateTime.Today.AddYears(-15));
        }

        private bool isMatValide(string Matricule)
        {
            if (string.IsNullOrEmpty(Matricule)||(Matricule.Length != 7))
            {
                return false;
            }

            for (int i = 0; i < Matricule.Length; i++)
            {
                if (i<2 && i>4)
                {
                    if (!char.IsDigit(Matricule[i]))
                    {
                        return false;
                    }
                    
                }
                if (i>1 && i<5)
                {
                    if (!char.IsLetter(Matricule[i]))
                    {
                        return false;
                    }
                }


            }
            return true; 
        }

        //Constructeur par défaut
        public Salarie()
        {
            CompteurInst++;
        }

        //Constructeur
        public Salarie(string matricule, string nom, string prenom):this()
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        //Constructeur de recopie
        public Salarie(Salarie salarie1):this(salarie1.Matricule,salarie1.Nom,salarie1.Prenom)
        {
            this.SalaireBrut = salarie1.SalaireBrut;
            this.TxCS = salarie1.TxCS;
            this.DateNaissance = salarie1.DateNaissance;
        }
        
        // override object.Equals
        public override bool Equals(object obj)
        {

            Salarie stSalarie = obj as Salarie;
            if (stSalarie == null || GetType() != stSalarie.GetType())
            {
                return false;
            }
            if (this._matricule == stSalarie._matricule)
                return true;
            else return false;

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here            
            return _matricule.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n",this.Matricule,this.Nom,
                this.Prenom,this.DateNaissance,this.SalaireBrut,this.TxCS,this.SalaireNet);
        }
    }

    public class Commercial : Salarie
    {
        private double _chiffreAffaire;
        private double _commission;
        public override double SalaireNet
        {
            get
            {
                return base.SalaireNet + (Commission*ChiffreAffaire);
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
        public Commercial(): base()
        {

        }

        //Constructeur
        public Commercial(string matricule, string nom, string prenom) :  base(matricule, nom, prenom)
        {
         
        }

        //Constructeur de recopie
        public Commercial(Commercial Commercial1): base(Commercial1)
        {
            this.ChiffreAffaire = Commercial1.ChiffreAffaire;
            this.Commission = Commercial1.Commission;
        }

        public override string ToString()
        {
            return string.Format("{0}\n ", base.ToString());
        }
    }

    public class ChangementSalaireEventArgs : EventArgs
    {
        private double _ancienSalaire;
        private double _nouveauSalaire;

        public ChangementSalaireEventArgs(double ancienSalaire, double nouveauSalaire)
        {
            AncienSalaire = ancienSalaire;
            NouveauSalaire = nouveauSalaire;
        }

        public double AncienSalaire
        {
            get
            {
                return _ancienSalaire;
            }

            set
            {
                _ancienSalaire = value;
            }
        }

        public double NouveauSalaire
        {
            get
            {
                return _nouveauSalaire;
            }

            set
            {
                _nouveauSalaire = value;
            }
        }
    }

}
