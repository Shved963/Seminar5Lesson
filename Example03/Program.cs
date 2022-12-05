// Задайте массив.
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 
//3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();

int[] arr = GenerateArray(-10, 10, 10);
PrintArray(arr);
bool isParsed = int.TryParse(Console.ReadLine(), out int num);
if (!isParsed)
{
    Console.WriteLine("Incorrect data");
    return;
}
bool result = FinderNumber(arr, num);
Console.WriteLine($"{num} - find number in array. It's {result}");


void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}], ");
}


bool FinderNumber(int[] array, int findNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (findNum == array[i])
        {
            return true;
        }       
    }
    return false;
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

