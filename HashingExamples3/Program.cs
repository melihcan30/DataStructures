using System;

namespace HashingExamples3
{
    class Hashing
    {
        // bir öğenin ayrıntıları
        class item
        {
            public String name;
            public int price;
            public item(String name, int price)
            {
                this.name = name;
                this.price = price;
            }
        }

        // her ikisinde de ortak olan öğeleri sayma işlevi
        // farklı fiyatlarla
        static int countItems(item[] list1, int m,item[] list2, int n)
        {
            int count = 0;

            // 'liste1'in her bir öğesi için' liste2'de olup olmadığını ve farklı fiyatta olduklarını kontrol edin 

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)

                    if ((list1[i].name.CompareTo(list2[j].name) == 0) &&
                        (list1[i].price != list2[j].price))
                        count++;
            // gerekli öğe sayısı
            return count;
        }

        public static void Main(String[] args)
        {
            item[] list1 = {new item("apple", 60), new item("bread", 20),
                new item("wheat", 50), new item("oil", 30)};
            item[] list2 = {new item("milk", 20), new item("bread", 15),
                new item("wheat", 40), new item("apple", 60)};

            int m = list1.Length;
            int n = list2.Length;

            Console.Write("Miktar = " + countItems(list1, m, list2, n));

            Console.ReadLine();
        }
    }
}
