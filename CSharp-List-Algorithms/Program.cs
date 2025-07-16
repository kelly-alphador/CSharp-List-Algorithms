using System;
using CSharp_List_Algorithms.Algorithms.Manipulation;


namespace Travail_algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManipulationAlgorithms algo = new ManipulationAlgorithms();

            // Liste d'entiers
            List<int> intList = new List<int> { 1, 2, 3, 4 };
            intList = algo.Reverse(intList);
            Console.WriteLine("Reverse int: " + string.Join(", ", intList));

            // Liste de caractères
            List<char> charList = new List<char> { 'a', 'b', 'c', 'd' };
            charList = algo.Reverse(charList);
            Console.WriteLine("Reverse char: " + string.Join(", ", charList));

            // Liste de chaînes
            List<string> stringList = new List<string> { "un", "deux", "trois", "quatre" };
            stringList = algo.Reverse(stringList);
            Console.WriteLine("Reverse string: " + string.Join(", ", stringList));

            // Liste d'objets
            List<object> objectList = new List<object> { 1, "deux", 3.0, '4' };
            objectList = algo.Reverse(objectList);
            Console.Write("Reverse object: ");
            foreach (var item in objectList)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}