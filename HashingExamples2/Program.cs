using System;

namespace HashingExamples2
{
    //İlk dizide olan ama ikinci dizi de olmayan elemanları bulma
    class Hashing
    {
        static void findMissing(int[] a, int[] b, int n, int m)

        {
            for (int i = 0; i < n; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;

                if (j == m)
                    Console.Write(a[i] + " ");
            }
        }

        public static void Main()
        {
            int[] a = { 1, 2, 6, 3, 4, 5 };
            int[] b = { 2, 4, 3, 1, 0 };

            int n = a.Length;
            int m = b.Length;

            findMissing(a, b, n, m);
        }
    }
}
