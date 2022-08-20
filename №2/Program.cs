class Program
{

    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-100, 300);
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
            if (i % 2 == 1)
            {
                s += array[i];
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + s);
    }



    static void Main(string[] args)
    {
        int[] array = CreaterArray(new Random().Next(3, 30));
        WriteArray(array);
        MultipleTwoNumber(array);
    }
}