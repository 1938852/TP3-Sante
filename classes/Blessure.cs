using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classes
{
    internal class Blessure : Probleme
    {
        public string _type {  get; set; }
        public Blessure(int nAS, string nom, string dateDebut, string dateFin, string desc, string type) : base(nAS, nom, dateDebut, dateFin, desc)
        {
            _type = type;
        }
    }
}
