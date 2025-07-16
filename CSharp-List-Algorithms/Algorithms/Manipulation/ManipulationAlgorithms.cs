using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_Algorithms.Algorithms.Manipulation
{
    public class ManipulationAlgorithms
    {
        // On utilise List<T> et <T> pour que la méthode soit générique 
        // Cela permet à l'utilisateur de passer n'importe quel type : int, string, object, etc.
        /// <summary>
        /// Ajoute une valeur à la fin de la liste.
        /// </summary>
        /// <typeparam name="T">Le type des éléments de la liste.</typeparam>
        /// <param name="a">L'élément à ajouter.</param>
        /// <param name="b">La liste existante.</param>
        /// <returns>La liste mise à jour avec l'élément ajouté à la fin.</returns>
        public List<T> Add<T>(T a, List<T> b)
        {
            // On crée un tableau temporaire avec une case de plus pour accueillir le nouvel élément
            T[] temp = new T[b.Count + 1];

            // On copie tous les éléments existants dans le tableau temporaire
            for (int i = 0; i < b.Count; i++)
            {
                temp[i] = b[i];
            }

            // On ajoute le nouvel élément à la fin du tableau
            temp[b.Count] = a;

            // On crée une nouvelle liste à partir du tableau temporaire
            List<T> NewList = new List<T>(temp);

            return NewList;
        }
        // Méthode AddRange personnalisée
        /// <summary>
        /// Ajoute plusieurs éléments à la liste.
        /// </summary>
        /// <typeparam name="T">Le type des éléments de la liste.</typeparam>
        /// <param name="b">La liste existante.</param>
        /// <param name="Taille">Le nombre d'éléments à ajouter.</param>
        /// <returns>La liste mise à jour avec les nouveaux éléments ajoutés.</returns>
        public List<T> AddRange<T>(List<T> b, int Taille)
        {
            for (int i = 0; i < Taille; i++)
            {
                Console.Write($"Entrez le contenu {i + 1}: ");
                string saisie = Console.ReadLine();

                // Convertir la saisie en T
                T element = (T)Convert.ChangeType(saisie, typeof(T));

                b = Add(element, b);
            }

            return b;
        }

        /// <summary>
        /// Ajoute une valeur à la fin de la liste.
        /// </summary>
        /// <typeparam name="T">Le type des éléments de la liste.</typeparam>
        /// <param name="a">L'élément à ajouter.</param>
        /// <param name="b">La liste existante.</param>
        /// <returns>La liste mise à jour avec l'élément ajouté à la fin.</returns>
        public List<T> Insert<T>(List<T> list, int index, T value)
        {
            // On vérifie que l'index est valide (>= 0 et <= taille de la liste)
            // Sinon, on lance une exception
            if (index < 0 || index > list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index invalide !");
            }

            // On crée un tableau temporaire d'une taille supérieure de 1
            T[] temp = new T[list.Count + 1];

            // On copie les éléments avant l'index dans le tableau temporaire
            for (int i = 0; i < index; i++)
            {
                temp[i] = list[i];
            }

            // On insère la nouvelle valeur à la position indiquée
            temp[index] = value;

            // On copie les éléments après l'index en les décalant d'une position
            for (int i = index; i < list.Count; i++)
            {
                temp[i + 1] = list[i];
            }

            // On crée une nouvelle liste à partir du tableau temporaire
            List<T> newList = new List<T>(temp);

            return newList;
        }
        /// <summary>
        /// Inverse l'ordre des éléments dans la liste.
        /// </summary>
        /// <param name="list">La liste existante.</param>
        /// <returns>La liste inverse</returns>
        public List<T> Reverse<T>(List<T> list)
        {
            T tmp;
            int count = list.Count;
            for (int i = 0; i < count / 2; i++)
            {
                tmp = list[i];
                list[i] = list[count - 1 - i];
                list[count - 1 - i] = tmp;
            }
            return list;
        }

        /// <summary>
        /// Calcule et retourne la somme de tous les éléments d'une liste.
        /// </summary>
        /// /// <param name="list">La liste existante.</param>
        /// <returns>La somme des elemets dans la liste</returns>
        public int Sum(List<int> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i];
            }
            return s;
        }

    }
}
