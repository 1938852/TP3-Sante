using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classes
{
    internal class Probleme
    {
        public int _NAS { get; set; }
        public string _Nom {  get; set; }
        public string _dateDebut { get; set; }
        public string _dateFin { get; set; }
        public string _description { get; set; }
        public Probleme()
        {
            _NAS = 0;
            _Nom = "Bobo";
            _dateDebut = "0001-01-01";
            _dateFin = "0001-01-02";
            _description = "Je ne devrais pas lire ça";
        }
        public Probleme(int nAS, string nom, string dateDebut, string dateFin, string description)
        {
            _NAS = nAS;
            _Nom = nom;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _description = description;
        }       
    }
}
