// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,
// значения которых лежат в
// отрезке [10,99].
Console.Clear();


int[] array = GenerateArray(-50,200,123);
PrintArray(array);
int numberOfHits = Counter(array);
Console.WriteLine($"Колличество попаданий в отрезок [10, 99] - {numberOfHits}");




void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}], ");
}

int Counter (int [] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        count++;
    }
    return count;
}


int[] GenerateArray(int min, int max, int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}