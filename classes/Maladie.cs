using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classes
{
    internal class Maladie: Probleme
    {
        public string _pathologie {  get; set; }
        public int _stade { get; set; }

        public Maladie(int nAS, string nom, string dateDebut, string dateFin, string desc, string pato, int stade) : base(nAS, nom, dateDebut, dateFin, desc)
        {
            _pathologie = pato;
            _stade = stade;
        }
    }
}
