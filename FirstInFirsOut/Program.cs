using System;
using System.Collections.Generic;

namespace FirstInFirsOut
{
    public class QueueExample
    {
        public static void Main(String[] args)
        {
            Queue<int> q = new Queue<int>();

            // Kuyruğa öğeleri ekleme
            for (int i = 0; i < 5; i++)
                q.Enqueue(i);

            // Kuyruğun içeriğini görüntüleme
            Console.Write("Elements of queue-");
            foreach (int s in q)
                Console.Write(s + " ");

            // Kuyruğun başını çıkarmak 
            int removedele = q.Dequeue();
            Console.Write("\nremoved element-" + removedele + "\n");
            foreach (int s in q)
                Console.Write(s + " ");

            // Kuyruğun başını görmek için
            int head = q.Peek();
            Console.Write("\nhead of queue-" + head);

            int size = q.Count;
            Console.WriteLine("\nSize of queue-" + size);
        }
    }
}
