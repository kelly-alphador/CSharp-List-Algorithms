using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_Algorithms.Algorithms.Manipulation
{
    public class ManipulationAlgorithms
    {
        /// <summary>
        /// Supprime toutes les occurrences d'un élément dans la liste.
        /// </summary>
        public List<T> SupprimerOccurrences<T>(List<T> list, T oc)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(list[i], oc))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        /// <summary>
        /// Ajoute un élément uniquement s'il n'existe pas déjà dans la liste.
        /// </summary>
        public List<T> AjouterSiAbsent<T>(List<T> list, T element)
        {
            bool existe = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(element, list[i]))
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                list.Add(element);
            }
            return list;
        }

        /// <summary>
        /// Ajoute un élément au milieu de la liste.
        /// </summary>
        public List<T> AjouterAuMilieu<T>(List<T> list, T element)
        {
            int milieu = list.Count / 2;
            T[] temp = new T[list.Count + 1];
            for (int i = 0; i < milieu; i++)
            {
                temp[i] = list[i];
            }
            temp[milieu] = element;
            for (int j = milieu; j < list.Count; j++)
            {
                temp[j + 1] = list[j];
            }
            return new List<T>(temp);
        }

        /// <summary>
        /// Remplace toutes les occurrences d’une valeur par une nouvelle valeur.
        /// </summary>
        public List<T> RemplacerValeurs<T>(List<T> list, T ancienneValeur, T nouvelleValeur)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], ancienneValeur))
                {
                    list[i] = nouvelleValeur;
                }
            }
            return list;
        }

        /// <summary>
        /// Supprime les entiers inférieurs ou égaux à une valeur donnée.
        /// </summary>
        public List<int> SupprimerInferieurOuEgal(List<int> list, int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > n)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        /// <summary>
        /// Sélectionne tous les nombres pairs d'une liste d'entiers.
        /// </summary>
        public List<int> ObtenirNombresPairs(List<int> list)
        {
            var result= list.Where(n => n % 2 == 0).ToList();
            return result;
        }

        /// <summary>
        /// Récupère toutes les chaînes qui commencent par la lettre "A".
        /// </summary>
        public List<string> ObtenirChainesCommencantParA(List<string> list)
        {
            var result =list.Where(n => n.StartsWith("A")).ToList();
            return result;
        }

        /// <summary>
        /// Récupère les personnes ayant plus de 30 ans.
        /// </summary>
        public List<Personne> ObtenirPersonnesAgeesDePlusDe30(List<Personne> list)
        {
            var result= list.Where(p => p.Age > 30).ToList();
            return result;
        }

        /// <summary>
        /// Sélectionne les produits dont le prix est inférieur à 50.
        /// </summary>
        public List<Produit> ObtenirProduitsMoinsDe50(List<Produit> list)
        {
            var result= list.Where(prod => prod.prix < 50).ToList();
            return result;
        }

        /// <summary>
        /// Récupère les employés du département "Vente".
        /// </summary>
        public List<Employe> ObtenirEmployesDuDepartementVente(List<Employe> list)
        {
            return list.Where(e => e.Departement == "Vente").ToList();
        }
    }
}
