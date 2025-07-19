using System;
using CSharp_List_Algorithms.Algorithms.Manipulation;
using CSharp_List_Algorithms.Algorithms.Searching;


namespace Travail_algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 1, 4, 1 };
            List<string> listString = new List<string> { "Alpha", "Brinda", "GAGA", "JEnny", "Olivia" };
            List<Personne> Person = new List<Personne>()
            {
                new Personne{Nom="Alpha",Age=21},
                new Personne{Nom="Olivia",Age=30},
                new Personne{Nom="Jose",Age=41},
                new Personne{Nom="Marthinien",Age=42}
            };
            List<Employe> employes = new List<Employe>
            {
                new Employe { id = 1, Nom = "Alice", Departement = "Informatique", Salaire = 3200.50 },
                new Employe { id = 2, Nom = "Bruno", Departement = "Ressources Humaines", Salaire = 2800.00 },
                new Employe { id = 3, Nom = "Catherine", Departement = "Comptabilité", Salaire = 3100.75 },
                new Employe { id = 4, Nom = "David", Departement = "Informatique", Salaire = 4000.00 },
                new Employe { id = 5, Nom = "Emma", Departement = "Marketing", Salaire = 2700.20 },
                new Employe { id = 6, Nom = "Farah", Departement = "Ventes", Salaire = 2600.00 },
                new Employe { id = 7, Nom = "Georges", Departement = "Comptabilité", Salaire = 2950.40 },
                new Employe { id = 8, Nom = "Hassan", Departement = "Ventes", Salaire = 2500.00 },
                new Employe { id = 9, Nom = "Isabelle", Departement = "Informatique", Salaire = 4200.00 },
                new Employe { id = 10, Nom = "Julien", Departement = "Marketing", Salaire = 3000.00 }
            };

            List<Produit> produits = new List<Produit>
            {
                new Produit { Nom = "Ordinateur", prix = 750 },
                new Produit { Nom = "Clavier", prix = 45 },
                new Produit { Nom = "Souris", prix = 25 },
                new Produit { Nom = "Écran", prix = 150 },
                new Produit { Nom = "Imprimante", prix = 120 },
                new Produit { Nom = "Casque", prix = 60 },
                new Produit { Nom = "Webcam", prix = 80 },
                new Produit { Nom = "Disque dur", prix = 100 },
                new Produit { Nom = "Chargeur", prix = 30 },
                new Produit { Nom = "Tapis de souris", prix = 10 }
            };

            ManipulationAlgorithms Algo =new ManipulationAlgorithms();
            //Algo.SupprimerOccurrences(list, 1);
            // Algo.AjouterSiAbsent(list, 1);
            //Algo.AjouterSiAbsent(list, 5);
            //Algo.AjouterAuMilieu(list, 5);
            //Algo.RemplacerValeurs(list, 1, 10);
            //Algo.SupprimerInferieurOuEgal(list, 5);
            //Algo.ObtenirNombresPairs(list);
            //Algo.ObtenirChainesCommencantParA(listString);
            //Algo.ObtenirPersonnesAgeesDePlusDe30(Person);
            Algo.ObtenirProduitsMoinsDe50(produits);
            Algo.ObtenirEmployesDuDepartementVente(employes);
        }
    }
}