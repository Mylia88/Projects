using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalariesDll;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.Xml;

namespace SalariesDll
{
    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class Salaries : List<Salarie>
    {
        public new void Add(Salarie salarie)
        {
            // if(ifExists(salarie))
            // {
            //   base.Add(salarie);
            //}
            //Méthode inutile car fonctionnalité implémentée par Contains
            if (!Contains(salarie))
            {
                base.Add(salarie);
            }
        }

        private bool ifExists(Salarie sal)
        {
            foreach (Salarie item in this)
            {
                if (item.Equals(sal))
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




        //Sérialisation CSV
        //Sauver les données
        public void SaveText(string Path)
        {
            FileStream fs = new FileStream(Path+@"\Salaries.csv", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            foreach(Salarie item in this)
            {
                sw.WriteLine(item.ToString());
            }

            sw.Close();
            fs.Close();
        }

        //Désérialisation
        // Charger les données
        public void LoadText(string Path)
        {
            FileStream fs = new FileStream(Path + @"\Salaries.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ChargeText = sr.ReadLine();

            //ou while(!string.IsNullOrEmpty(ChargeText))
            while (ChargeText != null)
            {
                string[] TabCh = ChargeText.Split(';');
                Salarie Sal2 = new Salarie(TabCh[0], TabCh[1], TabCh[2], DateTime.Parse(TabCh[3]), Double.Parse(TabCh[4]),
                    Double.Parse(TabCh[5]));
                this.Add(Sal2);
                ChargeText = sr.ReadLine();
            }
            

            sr.Close();
            fs.Close();          
        }

        //Sérialisation BINAIRE
        //Sauver les données
        public void SaveBinary(string Chemin)
        {
            FileStream fs = new FileStream(Chemin + @"\Salaries.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            
            fs.Close();
        }

        //Désérialisation
        //Charger les données
        public void LoadBinary(string Chemin)
        {
            FileStream fs = new FileStream(Chemin + @"Salaries.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            this.AddRange(bf.Deserialize(fs) as Salaries);

            fs.Close();
        }

        //Sérialisation XML
        //Sauver les données
        public void SaveXML(string Route)
        {
            FileStream fs = new FileStream(Route + @"\Salaries.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlTextWriter xmlTW = new XmlTextWriter(fs, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            xmlS.Serialize(xmlTW, this);
            fs.Close();
        }

        //Désérialisation
        //Charger les données
        public void LoadXML(string Route)
        {
            FileStream fs = new FileStream(Route + @"\Salaries.xml", FileMode.Open, FileAccess.Read);
            XmlTextReader xmlTR = new XmlTextReader(fs);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            this.AddRange(xmlS.Deserialize(xmlTR) as Salaries);
            fs.Close();
        }
    }

}
