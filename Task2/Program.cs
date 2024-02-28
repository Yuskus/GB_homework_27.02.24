// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int deep = 0;
int maxRecursionDeep = 70000000;

void Main()
{
    int m = InputNumber("Введите число m: ");
    int n = InputNumber("Введите число n: ");
    int ackermann = Ack(m, n);
    Console.WriteLine(ackermann == 0 ? "Выполнение рекурсии было прервано во избежание переполнения стека." : "Результат вычисления по функции Аккермана равен: " + ackermann);
    Console.WriteLine($"Глубина рекурсивной функции составила вызовов: {deep}");
}

int InputNumber(string text)
{
    Console.Write(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine() ?? "", out int number))
            return Math.Abs(number);
        Console.WriteLine("Ошибка. Попробуйте снова.");
    }
}

int Ack(int m, int n)
{
    deep++;
    if (deep > maxRecursionDeep) return 0;
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

Main();