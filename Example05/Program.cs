// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент,
// второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Clear();

int[] array = GenerateArray(1, 10, 8);
PrintArray(array);
int[] result = ProducedArray(array);
PrintArray(result);


int[] ProducedArray(int[] arr)
{
    int[] arr2 = arr2 = new int[arr.Length / 2 + arr.Length % 2];
  
    for (int i = 0; i < arr2.Length; i++)
    {
       if (i != arr.Length -i -1)
       {
        arr2[i] = arr[i] * arr[arr.Length - i - 1];
       }
       else
       {
        arr2[i] = arr[i];
       }
    }
    return arr2;
}

void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}], ");
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