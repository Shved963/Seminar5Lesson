// Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();

int[] array = GenerateArray(-20,20,10);
PrintArray(array);
int[] oppositiveArr = OppositeArray(array);
PrintArray(oppositiveArr);

void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}], ");
}


int [] OppositeArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
    return array;
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