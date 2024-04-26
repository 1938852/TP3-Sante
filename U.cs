using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_24
{
    internal class U
    {
        // Chemin classe:
        const string CHEMIN_FICHIERS = "C:\\utopia\\";
        
        public const string FICHIER_POP = CHEMIN_FICHIERS + "population.txt";
        public const string FICHIER_PROBLEMES = CHEMIN_FICHIERS + "problemes.txt";
        public const string FICHIER_UTILISATIONS = CHEMIN_FICHIERS + "utilisations.txt";

        //----------------------------------------------
        //
        //----------------------------------------------
        static public void Entete()
        {
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();
            CLR();

            W("\t\t\t");
            for (int i = 0; i < 33; i++)
                W("_");

            W("\t\t\t");
            WL("\n\t\t\t|\t\t\t\t|\n\t\t\t|\tVotre prénom nom \t|\n\t\t\t|\tprésente\t\t|\n\t\t\t|\tVISION SANTÉ\t\t|");
            W("\t\t\t");
            W("|");
            for (int i = 0; i < 31; i++)
                W("_");

            W("|");
            WL("\n");
        }


        //----------------------------------------------
        //
        //----------------------------------------------
        static public void Titre(string t)
        {
            foreach (char c in t)
            {
                W("-");
            }
            WL();
            WL(t);
            foreach (char c in t)
            {
                W("_");
            }
            WL("\n");
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public void WL(string t = "")
        {
            Console.WriteLine(t);
        }
        //----------------------------------------------
        //
        //----------------------------------------------
        static public void W(string t)
        {
            Console.Write(t);
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public string RL()
        {
            string? ret;
            ret = Console.ReadLine();
            if (ret != null)
            {
                return ret;
            }
            return "";
        }
        //----------------------------------------------
        //
        //----------------------------------------------
        static public char RC()
        {
            return Console.ReadKey().KeyChar;
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public void P()
        {
            WL("\nappuyez une touche...");
            Console.ReadKey();
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public void CLR()
        {
            Console.Clear();
            U.WL("\x1b[3J");
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public void Sep()
        {
            WL("_____________________________________________________________________________________________________________");
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public int Bidon()
        {
            return 0;
        }

        //----------------------------------------------
        //
        //----------------------------------------------
        static public char Referendum(string question)
        {
            W((question + " (O / N)"));

            char rep = RC();

            while (rep != 'O' && rep != 'o' && rep != 'N' && rep != 'n')
            {
                rep = U.RC();
            }
            return rep;
        }
    }
}
