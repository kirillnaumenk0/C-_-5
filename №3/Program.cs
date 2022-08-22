//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


class Program
{
    static int MaxArray(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int MinArray(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    static void Main(string[] args)
    {
        int[] array = { 11, 5, 15, 817, 236, 619 };
        int max = MaxArray(array);
        int min = MinArray(array);
        Console.WriteLine("Максимальное значение массива : " + max);
        Console.WriteLine("Минимальное значение массива : " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементов массиваmax : " + (max - min));
    }
}


