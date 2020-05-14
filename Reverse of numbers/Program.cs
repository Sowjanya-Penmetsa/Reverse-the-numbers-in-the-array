using System;
using System.Security.Cryptography.X509Certificates;

namespace Reverse_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            int[] Numbers = new int[5];
            for(int i=0;i<Numbers.Length;i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
               
             }

            //Numbers in the array before revrsing

            Console.WriteLine("The numbers in the array are :");
            foreach (int temp in Numbers)
            {
                
                Console.WriteLine(temp);
            }

            Array.Reverse(Numbers);

            // Numbers in the array after Reversing

            Console.WriteLine("The Reversed array is: ");
            foreach(int ReverseNumber in Numbers)
            {
                Console.WriteLine(ReverseNumber);
            }

            Console.ReadLine();
        }
    }
}
