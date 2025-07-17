using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_Algorithms.Algorithms.Searching
{
    public class SearchingAlgorithms
    {
        /// <summary>
        /// Vérifie si un élément existe dans la liste.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="item">L’élément à rechercher.</param>
        /// <param name="list">La liste dans laquelle chercher l’élément.</param>
        /// <returns>True si l’élément est trouvé, sinon False.</returns>
        public bool Contains<T>(T item, List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, list[i]))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retourne l’index de la première occurrence d’un élément dans la liste.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="item">L’élément à rechercher.</param>
        /// <param name="list">La liste dans laquelle chercher.</param>
        /// <returns>L’index de la première occurrence ou -1 si non trouvé.</returns>
        public int IndexOf<T>(T item,List<T> list)
        {
            for(int i = 0;i < list.Count;i++)
            {
                if(EqualityComparer<T>.Default.Equals(item,list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Retourne l’index de la dernière occurrence d’un élément dans la liste.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="item">L’élément à rechercher.</param>
        /// <param name="list">La liste dans laquelle chercher.</param>
        /// <returns>L’index de la dernière occurrence ou -1 si non trouvé.</returns>
        public int LastIndexOf<T>(T item,List<T> list)
        {
            int index=-1;
            for(int i=0;i<list.Count;i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, list[i]))
                {
                    index=i; 
                }
            }
            return index;
        }
        /// <summary>
        /// Retourne une liste des éléments en double dans la liste d'origine.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="list">La liste à analyser.</param>
        /// <returns>Une liste contenant les éléments en double (sans répétition).</returns>
        public List<T> TrouverDoublons<T>(List<T> list)
        {
            List<T> result = new List<T>();
            T tmp;

            for (int i = 0; i < list.Count; i++)
            {
                int test = 0;
                tmp = list[i];

                // Compter combien de fois tmp apparaît dans la liste
                for (int j = 0; j < list.Count; j++)
                {
                    if (EqualityComparer<T>.Default.Equals(tmp, list[j]))
                    {
                        test++;
                    }
                }
                //Test si c'est un doublon
                if (test > 1) 
                {
                    bool exist = false; // Réinitialisé à chaque itération

                    // Vérifier s'il est déjà ajouté dans la liste result
                    for (int k = 0; k < result.Count; k++)
                    {
                        if (EqualityComparer<T>.Default.Equals(result[k], tmp))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        result.Add(tmp);
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// Retourne la valeur minimale et maximale dans une liste.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste (doit implémenter IComparable).</typeparam>
        /// <param name="list">La liste à analyser.</param>
        /// <returns>Un objet contenant Min et Max.</returns>
        /// <exception cref="ArgumentException">Lancée si la liste est vide ou null.</exception>
        public MinMax<T> MinAndMax<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("La liste ne doit pas être vide.");

            T min = list[0];
            T max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(min) < 0)
                    min = list[i];

                if (list[i].CompareTo(max) > 0)
                    max = list[i];
            }

            return new MinMax<T>
            {
                Min = min,
                Max = max
            };
        }
        /// <summary>
        /// Calcule le nombre d’occurrences d’un élément donné dans une liste.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="list">La liste à analyser.</param>
        /// <param name="item">L’élément dont on veut compter les occurrences.</param>
        /// <returns>Le nombre d’occurrences de l’élément.</returns>
        public int NombreOccurence<T>(List<T> list,T item)
        {
            int nbOccurence = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(EqualityComparer<T>.Default.Equals(list[i],item))
                { 
                    nbOccurence++;
                }
            }
            return nbOccurence;
        }



    }
}
