using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array1();//Array1(numeroArray);
            List1();
        }

        public static void Array1()//public static void Array1(int[] numeroArray)
        {
            var numeroArray = new int[83];
            var numeroRandom = new Random();
            Console.WriteLine(numeroArray.Length);//tells how many indexes the array has in the console.
            Console.WriteLine("");
            //Console.WriteLine(numeroArray.Capacity);//.capacity only works for lists, not arrays.
            for (int i = 0; i < numeroArray.Length; i++)
            {
                numeroArray[i] = numeroRandom.Next(0, 84);
            }
            Console.WriteLine("");

            foreach (int num in numeroArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");
            //while (numeroArray.Length < 201)//I forgot -- an array's size cannot change once it's been initialized.... no wonder these following commands and functions did not work.
            //{
            //numeroArray.Add(numeroRandom.Next(0, 999));//.add doesn't seem to work for arrays either -- is it only limited to lists?
            //numeroArray++;//cannot increment directly to an array, probably has to be done through another variable that can act as a parser of its indexes, say through a for loop.
            //}
        }

        public static void List1()
        {
            List<int> numeroList = new List<int>();
            Console.WriteLine(numeroList.Capacity);
            Random numeroRange = new Random();

            Console.WriteLine("");
            //Populate and design the size of the list, preferably with smaller numbers.
            while (numeroList.Count <= 72)
            {
                numeroList.Add(numeroRange.Next(0, 73));
            }
            //Console.WriteLine(numeroList[numeroRange]);//This didn't work -- variable type was invalid.
            Console.WriteLine(numeroList.Capacity);
            Console.WriteLine("");
            //Print what's been populated within the list to the console.
            foreach (int numero in numeroList)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("");
            numeroList.Sort();
            //Console.WriteLine(numeroList);//Printed an undesired result to the console.
            //Print the same list, but now sorted.
            foreach (int numero in numeroList)//can use the same int variable over and over again.
            {
                Console.WriteLine(numero);
            }

            for (int numero = 0; numero < numeroList.Count; numero++)
            {
                if (numeroList[numero] % 2 == 0)
                {
                    numeroList[numero] = 0;//all even numbers are set to equal 0.
                }
            }
            //Print the same list, but now all even numbers are blocked out by 0.
            Console.WriteLine("");
            foreach (int numero in numeroList)
            {
                Console.WriteLine(numero);//printed numbers are still sorted by value.
            }
            Console.WriteLine("");

            while (numeroList.Count < 121)
            {
                numeroList.Add(numeroRange.Next(74, 122));
            }
            Console.WriteLine(numeroList.Capacity);
            Console.WriteLine("");
            foreach (int numero in numeroList)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
