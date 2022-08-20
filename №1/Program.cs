class Program
{

    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(300, 999);
        }
        return array;
    }


    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void MultipleTwoNumber(int[] array)
    {
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                s++;
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Количество чётных чисел в массиве: " + s);
    }



    static void Main(string[] args)
    {
        int[] array = CreaterArray(new Random().Next(3, 30));
        WriteArray(array);
        MultipleTwoNumber(array);
    }
}