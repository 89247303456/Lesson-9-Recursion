// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int CalculateSum(int m, int n)
    {
        if (m > n)
        {
            // Базовый случай: если m больше n, возвращаем 0
            return 0;
        }
        else
        {
            // Рекурсивно вызываем функцию для промежутка от m+1 до n и прибавляем m
            return m + CalculateSum(m + 1, n);
        }
    }

    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(m, n);
        Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");
    }