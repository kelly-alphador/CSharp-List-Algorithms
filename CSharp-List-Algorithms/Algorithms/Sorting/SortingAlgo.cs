using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_Algorithms.Algorithms.Sorting
{
    public class SortingAlgo
    {
        /// <summary>
        /// Trie une liste d'entiers en ordre croissant en utilisant l'algorithme optimisé de tri à bulles.
        /// </summary>
        /// <param name="list">La liste d'entiers à trier</param>
        /// <returns>La liste triée en ordre croissant</returns>
        public List<int> SortIntByAscending(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Trie une liste d'entiers en ordre décroissant en utilisant l'algorithme optimisé de tri à bulles.
        /// </summary>
        /// <param name="list">La liste d'entiers à trier</param>
        /// <returns>La liste triée en ordre croissant</returns>
        public List<int> SortIntByDescending(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Compare deux chaînes de caractères selon l'ordre alphabétique.
        /// </summary>
        /// <param name="a">Première chaîne à comparer.</param>
        /// <param name="b">Deuxième chaîne à comparer.</param>
        /// <returns>
        /// -1 si a est avant b,  
        ///  1 si a est après b,  
        ///  0 si a et b sont égales.
        /// </returns>
        public int CompareString(string a, string b)
        {
            int minLength = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] < b[i])
                {
                    return -1;
                }
                else if (a[i] > b[i])
                {
                    return 1;
                }
            }
            if (a.Length < b.Length)
            {
                return -1;
            }
            else if (a.Length > b.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Trie une liste de chaînes en ordre alphabétique en utilisant l'algorithme optimisé de tri à bulles.
        /// </summary>
        /// <param name="list">La liste de chaînes à trier</param>
        /// <returns>La liste triée en ordre alphabétique</returns>
        public List<string> SortStrinsByASceding(List<string> list)
        {
            string tmp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (CompareString(list[i], list[i + 1]) > 0)
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Trie une liste de chaînes en ordre alphabétique décroissant (de Z à A) 
        /// en utilisant l'algorithme optimisé de tri à bulles.
        /// </summary>
        /// <param name="list">La liste de chaînes à trier.</param>
        /// <returns>La liste triée en ordre alphabétique décroissant.</returns>

        public List<string> SortStrinsByDescending(List<string> list)
        {
            string tmp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (CompareString(list[i], list[i + 1]) < 0)
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Trie une liste de produits en ordre décroissant selon le prix.
        /// </summary>
        /// <param name="list">La liste de produits à trier.</param>
        /// <returns>La liste triée en ordre décroissant selon le prix.</returns>
        public List<Produit> SortProductByPrice(List<Produit> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].Prix < list[j + 1].Prix)
                    {
                        var tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Fusionne deux listes triées en une seule liste triée.
        /// </summary>
        /// <param name="list1">Première liste triée d'entiers.</param>
        /// <param name="list2">Deuxième liste triée d'entiers.</param>
        /// <returns>Une nouvelle liste triée contenant tous les éléments des deux listes.</returns>
        public List<int> FusionList(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] <= list2[j])
                {
                    result.Add(list1[i]);
                    i++;
                }
                else
                {
                    result.Add(list2[j]);
                    j++;
                }
            }

            // Ajouter le reste des éléments s’il en reste
            while (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                result.Add(list2[j]);
                j++;
            }

            return result;
        }

    }
}
