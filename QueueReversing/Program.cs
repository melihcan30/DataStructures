using System;
using System.Collections.Generic;

namespace QueueReversing
{
    //Kuyruğu ters çevirme
    public class Queue
    {
        public static LinkedList<int> queue;

        // Kuyruğu yazdırmak için yardımcı fonksiyon
        public static void Print()
        {
            while (queue.Count > 0)
            {
                Console.Write(queue.First.Value + ", ");
                queue.RemoveFirst();
            }
        }

        // Sırayı tersine çevirme işlevi 
        public static void Reversequeue()
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.First.Value);
                queue.RemoveFirst();
            }
            while (stack.Count > 0)
            {
                queue.AddLast(stack.Peek());
                stack.Pop();
            }
        }
 
        public static void Main(string[] args)
        {
            queue = new LinkedList<int>();
            queue.AddLast(10);
            queue.AddLast(20);
            queue.AddLast(30);
            queue.AddLast(40);
            queue.AddLast(50);
            queue.AddLast(60);
            queue.AddLast(70);
            queue.AddLast(80);
            queue.AddLast(90);
            queue.AddLast(100);

            Reversequeue();
            Print();
        }
    }
}
