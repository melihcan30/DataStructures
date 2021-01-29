using System;

namespace HeapExample2
{
    public class Heap
    {

        //Oluşturulan iki sayının toplamını verir
        // a[] içindeki tüm rakamlardan
        static int minSum(int[] a, int b)
        {
            // öğeleri sırala
            Array.Sort(a);

            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < b; i++)
            {
                if (i % 2 == 0)
                    num1 = num1 * 10 + a[i];
                else num2 = num2 * 10 + a[i];
            }
            return num2 + num1;
        }

        static public void Main()
        {
            int[] arr = { 5, 3, 0, 7, 4 };
            int b = arr.Length;
            Console.WriteLine("Gerekli miktar = " + minSum(arr, b));

            Console.ReadLine();
        } 
    }

}
