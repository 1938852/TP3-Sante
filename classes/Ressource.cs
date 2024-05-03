using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classes
{
    internal class Ressource
    {
        public int _NAS { get; set; }
        public string _codePS {  get; set; }
        public string _etablissement { get; set; }
        public string _date {  get; set; }
        public Ressource()
        {
            _NAS = 0;
            _codePS = "";
            _etablissement = "";
            _date = "";
        }

        public Ressource (int nas, string PS, string etab, string date)
        {
            _NAS = nas;
            _codePS = PS;
            _etablissement = etab;
            _date = date;
        }
    }
}
