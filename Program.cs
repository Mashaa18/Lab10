using System;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите количество элементов массива: ");
            int elements= int.Parse(Console.ReadLine());
            int[] myArray= new int[elements];  
            for (int i=0; i<myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:");
                myArray[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < elements; i++)
            {
               
                Console.WriteLine(myArray[i]);
            }
            int sr = myArray.Sum()/elements;
            Console.WriteLine($"\nСреднее арифметическое  ~ {sr} ");
            int ch = 0; int nch = 0;
            for ( int i=0;  i<myArray.Length; i++)
            {
               
                if (myArray[i] % 2 == 0)
                {
                    ch += myArray[i];
                }
                else
                {
                    nch += myArray[i];
                }

            }
            Console.WriteLine("Сумма четных цифр числа = " + ch);
            Console.WriteLine("Сумма нечетных цифр числа = " + nch);
            Console.ReadKey();
        }


    }
}

