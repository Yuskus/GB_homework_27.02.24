// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = InputInt("Введите натуральное число M: ");
    int N = InputInt("Введите натуральное число N: ");
    Console.WriteLine("Все натуральные числа от M до N (включительно): ");
    RecursionOutput(M, N, WhoIsBigger(M, N));
}

int InputInt(string text)
{
    Console.Write(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine() ?? "", out int number))
            if (number >= 0) return number;
        Console.WriteLine("Ошибка. Попробуйте снова.");
    }
}

int WhoIsBigger(int m, int n)
{
    if (m > n) return -1;
    else if (m < n) return 1;
    return 0;
}

void RecursionOutput(int m, int n, int step)
{
    if (m == n) { Console.Write(n); return; }
    Console.Write(m + " ");
    RecursionOutput(m + step, n, step);
}

Main();