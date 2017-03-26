using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomN
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte a = Convert.ToByte(Console.ReadLine());

            byte[] array = new byte[a];
            Random r = new Random();

            r.NextBytes(array);

            int sum = 0;
            //double avarage = ;
            for (int i = 0; i < array.Length; i++ )
            {
                Console.WriteLine(array[i]);
                sum += array[i];
            }

            Console.WriteLine("Max value: {0}", array.Max());
            Console.WriteLine("Min value: {0}", array.Min());
            Console.WriteLine("Sum is: {0}", sum);
            Console.WriteLine("Avarage is: {0}", Convert.ToDouble(sum) / Convert.ToDouble(array.Length));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1) { 
                    Console.WriteLine(array[i]); 
                }
 
            }
            Console.ReadKey();
        }
    }
}
