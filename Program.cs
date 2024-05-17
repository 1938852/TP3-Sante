using System;
using TP3_24.classes;
using TP3_24.classesUtilitaires;

namespace TP3_24
{
    class Program
    {
        public static List<Citoyen> _Citoyens = new List<Citoyen>();
        public static List<Professionnel> _Proffessionnels = new List<Professionnel>();
        public static List<Probleme> _Problemes = new List<Probleme>();
        public static List<Ressource> _Ressources = new List<Ressource>();
        static Citoyen cit = new();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            ChargerCitoyens();
            ChargerProblemes();
            ChargerProblemesCit();
            ChargerRessources();
            ChargerRessourcesCit();

            U.P();

            Menu menu = new Menu("Profils offerts");

            menu._Options.Add(new MenuItem("Profil citoyen", 'C', ProfilCitoyen));
            menu._Options.Add(new MenuItem("Profil professionnel de la santé", 'P', ProfilProfessionnelSante));

            menu.Afficher();
            menu.SaisirOption();
        
        }

        private static int ProfilCitoyen()
        {
            U.Entete();

            U.W("NAS du citoyen désiré:");
            int entree = int.Parse(U.RL());

            foreach(Citoyen cit in _Citoyens) 
            {
                if (entree == cit._NAS)
                {
                    cit.AfficherSommaire();
                }
            }            
            return 0;
        }

        private static int ProfilProfessionnelSante()
        {
            U.Entete();

            U.W("Code PS du professionnel: ");
            string entree = U.RL();
            foreach (Professionnel pro in _Proffessionnels)
            {
                if (entree == pro.CodePS)
                {
                    pro.AfficherSommaire();
                }
            }
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
        }

        public static void ChargerProblemes()
        {
            if (File.Exists(U.FICHIER_PROBLEMES))
            {
                StreamReader reader = File.OpenText(U.FICHIER_PROBLEMES);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    Probleme prob = new Probleme();

                    if (Parseur.ParsingProbleme(ligneCourante, ref prob))
                    {
                        _Problemes.Add(prob);
                    }
                }
                reader.Close();
            }
            U.WL($"{_Problemes.Count} problèmes chargés");
        }

        public static void ChargerRessources()
        {
            if (File.Exists(U.FICHIER_UTILISATIONS))
            {
                StreamReader reader = File.OpenText(U.FICHIER_UTILISATIONS);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    Ressource ress = new Ressource();

                    if (Parseur.ParsingRessource(ligneCourante, ref ress))
                    {
                        _Ressources.Add(ress);
                    }
                }
                reader.Close();
            }
            U.WL($"{_Problemes.Count} problèmes chargés");
        }

        public static void ChargerProblemesCit()
        {
            foreach(Citoyen cit in _Citoyens)
            {
                foreach(Probleme prob in _Problemes)
                {
                    if (prob._NAS == cit._NAS)
                    {
                        cit._problemes.Add(prob);
                    }
                }
            }
        }

        public static void ChargerRessourcesCit()
        {
            foreach (Citoyen cit in _Citoyens)
            {
                foreach (Ressource ress in _Ressources)
                {
                    if (ress._NAS == cit._NAS)
                    {
                        cit._utilisations.Add(ress);
                    }
                }
            }
        }

        /*private static void ChargerProffessionels()
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
        }*/


    }
}
