using System;
using System.Collections.Generic;

namespace LastInFirstOut
{
    class LIFO
    {
        // Yığının üst kısmındaki itme elemanı 
        static void stack_push(Stack<int> stack)
        {
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
        }

        // Yığının tepesinden çıkan öğe
        static void stack_pop(Stack<int> stack)
        {
            Console.WriteLine("Pop :");

            for (int i = 0; i < 5; i++)
            {
                int y = (int)stack.Pop();
                Console.WriteLine(y);
            }
        }

        // Yığının üstünde görüntülenen öğe
        static void stack_peek(Stack<int> stack)
        {
            int element = (int)stack.Peek();
            Console.WriteLine("Yığın üstündeki öğe : " + element);
        }

        // Yığındaki öğe aranıyor 
        static void stack_search(Stack<int> stack, int element)
        {
            bool pos = stack.Contains(element);

            if (pos == false)
                Console.WriteLine("Öğe bulunamadı");
            else
                Console.WriteLine("Eleman pozisyonda bulunur " + pos);
        }

        public static void Main(String[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack_push(stack);
            stack_pop(stack);
            stack_push(stack);
            stack_peek(stack);
            stack_search(stack, 2);
            stack_search(stack, 6);
        }
    }
}
