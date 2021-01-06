using System;

namespace D_line_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 6, 7, 10, 13, 15 };
            //int n = 10; // искомое число 


            float n = float.Parse(Console.ReadLine());

            Console.WriteLine(bin_search(array, n));
            //Console.WriteLine($"Длина массива: {(array.Length-1)/2}");

        }

        static double bin_search(int[] my_array, float n)
        {

           
            int min = 0;
            int max = my_array.Length;



            for (int i = min; i < max; i++)
            {
                if (my_array[i] == n)
                {

                    Console.WriteLine($"Искомый индекс: {i}");
                    return i;

                }
            }




            return -1;

        }

    }
}
