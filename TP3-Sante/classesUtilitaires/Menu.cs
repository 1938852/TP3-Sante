using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3_VisionSante;

namespace Tp3_VisionSante.classesUtilitaires
{
    internal class Menu
    {
        public string _Nom;
        public List<MenuItem> _Options;

       
        //----------------------------------------------
        //
        //----------------------------------------------
        public Menu(string n)
        {
            _Nom = n;
            _Options = new List<MenuItem>();
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        public void Afficher(bool clear=true)
        {
            if (clear)
            {
                U.Entete();
            }
            U.Titre(_Nom);
            foreach (MenuItem option in _Options)
            {
                if (option._Cle != '*')
                {
                    U.WL("\t" + option._Cle + ": " + option._Item);
                }
                else
                {
                    U.WL();
                }
            }
            U.WL("\nEsc pour quitter");
            U.WL("\nVotre choix:");
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        public void SaisirOption()
        {
            ConsoleKeyInfo cle;
            while ((cle = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                foreach (MenuItem option in _Options)
                {
                    if (option != null)
                    {
                        if ((char)cle.Key == option._Cle)
                        {
                            U.CLR();
                            option._Action();
                            Afficher();
                        }
                    }
                }
            }
        }
    }
}
