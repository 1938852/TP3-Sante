﻿using System;
using TP3_24.classes;
using TP3_24.classesUtilitaires;

namespace TP3_24
{
    class Program
    {
        public static List<Citoyen> _Citoyens = new List<Citoyen>();
        public static List<Professionnel> _Proffessionnels = new List<Professionnel>();
        static Citoyen cit = new();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            ChargerCitoyens();

            Menu menu = new Menu("Profils offerts");

            menu._Options.Add(new MenuItem("Profil citoyen", 'C', ProfilCitoyen));
            menu._Options.Add(new MenuItem("Profil professionnel de la santé", 'P', ProfilProfessionnelSante));

            menu.Afficher();
            menu.SaisirOption();
        
        }

        private static int ProfilCitoyen()
        {
            U.Entete();
            cit.AfficherSommaire();
            return 0;
        }

        private static int ProfilProfessionnelSante()
        {
            U.Entete();
            Professionnel ps = new();
            ps.AfficherSommaire();
            return 0;
        }

        private static void ChargerCitoyens()
        {
            if (File.Exists(U.FICHIER_POP))
            {
                StreamReader reader = File.OpenText(U.FICHIER_POP);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    Citoyen citoyen = new Citoyen();

                    if (Parseur.ParsingCitoyen(ligneCourante, ref citoyen))
                    {
                        _Citoyens.Add(citoyen);
                    }
                }
                reader.Close();
            }
            U.WL($"{_Citoyens.Count} citoyens chargés");
            U.P();
        }

        private static void ChargerProffessionels()
        {
            if (File.Exists(U.FICHIER_POP))
            {
                StreamReader reader = File.OpenText(U.FICHIER_POP);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    Professionnel proff = new Professionnel();

                    if (Parseur.ParsingProffessionnel(ligneCourante, ref proff))
                    {
                        _Proffessionnels.Add(proff);
                    }
                }
                reader.Close();
            }
            U.WL($"{_Citoyens.Count} proffessionels chargés");
            U.P();
        }

        private static void ChargerProblemes()
        { 

        }
    }
}
