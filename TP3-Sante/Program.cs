using System;
using Tp3_VisionSante.classes;
using Tp3_VisionSante.classesUtilitaires;

namespace Tp3_VisionSante
{
    class Program
    {
        static Citoyen cit = new();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

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
    }
}
