using System;

namespace HeapSort
{
    public class HeapSort
    {
        public void sort(int[] arr)
        {
            int m = arr.Length;

            // Yığın oluşturun (diziyi yeniden düzenleme)
            for (int i = m / 2 - 1; i >= 0; i--)
                heapify(arr, m, i);

            // Yığından bir öğeyi tek tek çıkarma
            for (int i = m - 1; i > 0; i--)
            {
                // Mevcut kökü sona taşıma
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0);
            }
        }

        // İ düğümüne sahip bir alt ağacı öbeklemek için
        void heapify(int[] arr, int m, int i)
        {
            int largest = i; 
            int j = 2 * i + 1;
            int k = 2 * i + 2;

            // Sol çocuk kökten büyükse
            if (j < m && arr[j] > arr[largest])
                largest = j;

            // Doğru çocuk şimdiye kadarki en büyük olandan büyükse
            if (k < m && arr[k] > arr[largest])
                largest = k;

            // En büyüğü kök değilse
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Etkilenen alt ağacı yinelemeli olarak yığınla
                heapify(arr, m, largest);
            }
        }

        // n boyutundaki diziyi yazdırmak için
        static void printArray(int[] arr)
        {
            int m = arr.Length;
            for (int i = 0; i < m; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }

        public static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int m = arr.Length;

            HeapSort ob = new HeapSort();
            ob.sort(arr);

            Console.WriteLine("Sıralanmış dizi");
            printArray(arr);
        }
    }
}
