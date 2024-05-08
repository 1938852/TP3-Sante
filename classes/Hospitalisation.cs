using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classes
{
    internal class Hospitalisation: Ressource
    {
        public string _dateFin {  get; set; }
        public int _chambre {  get; set; }

        public Hospitalisation(int nas, string PS, string etab, string date, string fin, int chambre) : base(nas, PS, etab, date) 
        {
            _dateFin = fin;
            _chambre = chambre;
        }
    }
}
