Console.Clear();

int[] array = GenerateArray(-9, 9, 12);
PrintArray(array);
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);

Console.WriteLine($"Сумма положительных чисел {sumPositiveNumbers}, сумма отрицательных чисел {sumNegativeNumbers}");

void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}]");
}

int GetSumPositiveNumbersInArray(int[] array)
{
    int sumPositiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositiveNumbers += array[i];
        }
    }

    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int sumNegativeNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumNegativeNumbers += array[i];
        }
    }

    return sumNegativeNumbers;
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