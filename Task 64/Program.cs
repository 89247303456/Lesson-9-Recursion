//Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с 
//помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
   {
        int N = int.Parse(Console.ReadLine());

        Console.Write("Рекурсивный вывод: ");
        RecursionPrint(N);

        Console.WriteLine();
   }

    static void RecursionPrint(int num)
    {
        if (num >= 1)
        {
            Console.Write(num + ", ");
            RecursionPrint(num - 1);
        }
    }