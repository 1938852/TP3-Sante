using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_24.classes;
using TP3_24.classesUtilitaires;

namespace TP3_24.classes
{
    class Citoyen
    {
        public int _NAS { get; set; }
        public string _nom {  get; set; }
        public string _naissance { get; set; }

        public List<Probleme> _problemes { get; set; }
        public List<Ressource> _utilisations { get; set; }

        public Citoyen()
        {
            _NAS = 0;
            _nom = "Roger Poirier";
            _naissance = "1949-11-15";
            _problemes = new List<Probleme>();
            _utilisations = new List<Ressource>();
        }

        public Citoyen(int nas, string nom, string naiss)
        {
            _NAS = nas;
            _nom = nom;
            _naissance = naiss;
            _problemes = new List<Probleme>();
            _utilisations = new List<Ressource>();
        }       

        public bool AfficherSommaire()
        {                     
            U.Entete();
            U.WL("\n------------------------------------------------------------------");
            U.WL($"Nom: \t\t{_nom}");
            U.WL($"Né le:\t\t{_naissance}");
            U.WL($"NAS:\t\t { _NAS}");
            U.WL("\n------------------------------------------------------------------");

            U.WL("Historique");
            U.WL("\t8 problèmes");
            U.WL("\t9 ressources utilisées");
            U.WL("\n");

            Menu menuCitoyen = new Menu("Consulter problèmes ou ressources?");
            menuCitoyen._Options.Add(new MenuItem("Problèmes", 'P', AfficherSommaireProblemes));
            menuCitoyen._Options.Add(new MenuItem("Ressources", 'R', AfficherSommaireRessources));
            menuCitoyen.Afficher(false);
            menuCitoyen.SaisirOption();
          
            return true;
        }

        public int AfficherSommaireProblemes()
        {
            U.Entete();
            U.WL("Problèmes médicaux\n----------------------------------------\n");
            U.WL("\t4 maladies");
            U.WL("\t3 blessures");

            U.WL("\n");

            Menu menuProb = new Menu("Consulter blessures ou maladies de Roger Poirier?");
            menuProb._Options.Add(new MenuItem("Blessures", 'B', AfficherBlessures));
            menuProb._Options.Add(new MenuItem("Maladies", 'M', AfficherMaladies));
            menuProb._Options.Add(new MenuItem("Tous problèmes", 'T', AfficherTousProblemes));
            menuProb.Afficher(false);
            menuProb.SaisirOption();
            return 0;
        }


        public int AfficherSommaireRessources()
        {
            U.Entete();
            U.WL("Ressources utilisées\n----------------------------------------\n");
            U.WL("\t3 rendez-vous");
            U.WL("\t2 hospitalisations");

            U.WL("\n");

            Menu menuRess = new Menu("Consulter Rendez-Vous ou Hospitalisations de Roger Poirier?");
            menuRess._Options.Add(new MenuItem("Rendez-vous", 'R', AfficherRendezVous));
            menuRess._Options.Add(new MenuItem("Hospitalisation", 'H', AfficherHospitalisations));
            menuRess._Options.Add(new MenuItem("Toutes les ressources", 'T', AfficherToutesRessources));
            menuRess.Afficher(false);
            menuRess.SaisirOption();
    
            return 0;

        }

        public int AfficherBlessures()
        {
            U.Entete();
            U.WL("Blessures de Roger Poirier:\n");
            U.WL("Type            Début      Guérison   Description ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Fracture", "2020-03-24", "2020-03-26", "Fracture ouverte du tibia");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Brûlure", "2019-06-21", "2019-08-31", "Brûlure 2ième degr au visage");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Contusion", "2017-12-24", "2018-02-11", "Hématome majeur suite à un accident d'auto");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Intoxication", "2007-03-02", "2007-03-21", "Perte de vision suite à surdose d'alcool");
           
            U.P();
            return 0;

        }
        public int AfficherMaladies()
        {
            U.Entete();
            U.WL("Maladies de Roger Poirier:\n");
            U.WL("Pathologie             Stade  Début    Guérison   Commentaire ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Schlérose en plaques", "3", "1998-01-24", "", "État chronique mais stable");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Cancer de la prostate", "1", "2008-01-24", "2013-01-31", "Aucune récidive après plus de 5 ans");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Gonorrhée", "1", "1998-01-24", "1998-02-14", "Guérison après antibiotiques");

            U.P();
            return 0;

        }
        public int AfficherTousProblemes()
        {
            U.Entete();
            U.WL("Problèmes médicaux de Roger Poirier:\n");
            
            U.WL("Blessures:");
            U.WL("Type            Début      Guérison   Description ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Fracture", "2020-03-24", "2020-03-26", "Fracture ouverte du tibia");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Brûlure", "2019-06-21", "2019-08-31", "Brûlure 2ième degr au visage");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Contusion", "2017-12-24", "2018-02-11", "Hématome majeur suite à un accident d'auto");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Intoxication", "2007-03-02", "2007-03-21", "Perte de vision suite à surdose d'alcool");
            U.WL( );
            U.WL("Maladies:");
            U.WL("Pathologie             Stade  Début    Guérison   Commentaire ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Schlérose en plaques", "3", "1998-01-24", "", "État chronique mais stable");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Cancer de la prostate", "1", "2008-01-24", "2013-01-31", "Aucune récidive après plus de 5 ans");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Gonorrhée", "1", "1998-01-24", "1998-02-14", "Guérison après antibiotiques");
            U.P();
            return 0;
        }

        public int AfficherRendezVous()
        {
            U.Entete();
            U.WL("Rendez-vous de Roger Poirier:\n");
            Console.WriteLine("{0,-22} {1,-12} {2,8}", "Établissement", "  Date", "Code PS");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CLSC Rosemère", "2022-02-13", "NC-103");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "Clinique MTS", "2012-02-13", "MG-803");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CH St-Jérôme", "2017-02-13", "UR-504");

            U.P();
            
            return 0;
        }
        public int AfficherHospitalisations()
        {
            U.Entete();
            U.WL("Hospitalisations  de Roger Poirier:\n");
            Console.WriteLine("{0,-22} {1,-12} {2,8} {3,-8} {4,-12}", "Établissement", "  Arrivée", "Code PS", "Chambre", "  Départ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CUSM", "2022-02-03", "NC-103", "233", "");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CH Hotel Dieu", "1995-12-03", "MG-512", "D-1233", "1996-02-03");
            U.P();

            return 0;
        }
        public int AfficherToutesRessources()
        {
            U.Entete();
            U.WL("Ressources utilisées par Roger Poirier:\n");
            U.WL("--------------------------------------");
            U.WL("Rendez-vous:");
            Console.WriteLine("{0,-22} {1,-12} {2,8}", "Établissement", "  Date", "Code PS");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CLSC Rosemère", "2022-02-13", "NC-103");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "Clinique MTS", "2012-02-13", "MG-803");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CH St-Jérôme", "2017-02-13", "UR-504");
            U.WL();
            U.WL("Hospitalisations:");
            Console.WriteLine("{0,-22} {1,-12} {2,8} {3,-8} {4,-12}", "Établissement", "  Arrivée", "Code PS" , "Chambre", "  Départ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CUSM", "2022-02-03", "NC-103", "233", "");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CH Hotel Dieu", "1995-12-03", "MG-512", "D-1233", "1996-02-03");
            U.P();
            return 0;
        }
    }
}
