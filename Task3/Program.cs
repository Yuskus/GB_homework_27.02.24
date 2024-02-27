// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = GenerateArray(10, 10, 100);
    PrintMyArray(array);
    Console.Write("В обратную сторону: ");
    RecursionOutput(array, array.Length-1);
}

int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(min, max);
    return array;
}

void PrintMyArray(int[] array)
{
    Console.WriteLine("Наш сгенерированный массив: " + string.Join(", ", array));
}

void RecursionOutput(int[] array, int index)
{
    if (index == -1) return;
    Console.Write(array[index]+" ");
    RecursionOutput(array, index - 1);
}

Main();