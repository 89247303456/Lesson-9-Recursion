//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
    }

// В этой версии программа запрашивает у пользователя 
// значения m и n с помощью метода Console.ReadLine(), 
// а затем использует метод int.Parse() для преобразования 
// введенной строки в целое число. Затем программа вызывает
// функцию Ackermann с введенными значениями и выводит результат 
// на консоль.
