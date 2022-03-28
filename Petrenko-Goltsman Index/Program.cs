using System;

namespace Petrenko_Goltsman_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexCalculation indexCalculation = new IndexCalculation();

            Console.WriteLine("Введите строку на русском языке");

            string rusString = Console.ReadLine();

            Console.WriteLine("Введите строку на английском языке и комментарий");

            string engString = Console.ReadLine();

            double rusIndex = indexCalculation.indexPetrenkoRus(rusString);

            double engIndex = indexCalculation.indexPetrenkoEng(engString);

            Console.WriteLine("Индекс Петренко для строки на русском языке - " + rusIndex.ToString());

            Console.WriteLine("Индекс Петренко для строки на английском языке и комментария - " + engIndex.ToString());

            if (rusIndex == engIndex)
            {
                Console.WriteLine("Индекс Петренко для строки на русском языке и индекс Петренко для строки на"
                                 + " английском языке и комментария совпадают. Их индекс: " + rusIndex.ToString());
            }

            Console.ReadKey();

        }
    }
}
