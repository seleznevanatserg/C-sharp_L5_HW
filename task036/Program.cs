// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
//  [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

int [] userArray = SettingsAndGenerateArray();
PrintArrayWhisIndex(userArray);
Console.WriteLine($"{SumNumbersWithUnevenIndex (userArray)} - sum numbers with uneven index in array");

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

int InputIntNumberTryParse()
{
    Console.WriteLine("Enter number, please.");
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        Console.WriteLine($"{num} -- it's number user entered.");
        return num;
    }
}

int[] SettingsAndGenerateArray()
{
    Console.WriteLine("Welcom, user. It's module settings for one-dimensional array.");
    Console.WriteLine("Follow the instructions.");

    Console.WriteLine("You must specify the number of array elements.");
    int length = InputIntNumberTryParse();
    Console.WriteLine("You must specify minimum value for generate array.");
    int min = InputIntNumberTryParse();
    Console.WriteLine("You must specify maximum value for generate array.");
    int max = InputIntNumberTryParse();

    int [] array = GenerateArray(min, max, length);
    return array;
}

int SumNumbersWithUnevenIndex (int [] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
        i++;
    }
    return sum;
}

void PrintArrayWhisIndex(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"({array[i]})[{i}] ");
    }
    Console.WriteLine();
}