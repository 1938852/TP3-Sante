﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_24.classes;

namespace TP3_24.classesUtilitaires
{
    internal class Parseur
    {

        public static bool ParsingCitoyen(string? infoBrute, ref Citoyen cit)
        {
            if (infoBrute == null || infoBrute.Length == 0)
                return false;

            int nbChamps = CompterNbChamps(infoBrute);
            if (nbChamps == 3)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                cit = new Citoyen(int.Parse(tabInfoBrute[0]), tabInfoBrute[1], tabInfoBrute[2]);
              
            }
            return false;
        }

        static int CompterNbChamps(string info)
        {
            if (info.Length == 0)
                return 0;

            int compteur = 0;
            foreach (char ch in info)
            {
                if (ch == ';')
                    compteur++;
            }
            return compteur + 1;
        }
    }
}