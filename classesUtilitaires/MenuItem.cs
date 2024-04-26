using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24.classesUtilitaires
{
    internal class MenuItem
    {
        public string _Item { get; set; }
        public char _Cle { get; set; }
        public Func<int> _Action { get; set; }


        //----------------------------------------------
        //
        //----------------------------------------------
        public MenuItem(string i, char c, Func<int> aExecuter)
        {
            _Item = i;
            _Cle = c;
            _Action = aExecuter;
        }
    }
}
