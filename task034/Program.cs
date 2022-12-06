//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] userArray = GenerateArray(100, 1000, InputIntNumberTryParse());
PrintArray(userArray);
int result = CounterEvenNumbers(userArray);
Console.WriteLine($"{result} it's amount even numbers in array (up).");


// Метод для подсчёта количества чётных значений элементов в массиве.
int CounterEvenNumbers(int [] array)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        i++;
    }
    return count;
}
// Печать элементов массива.
void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}
// Метод генерации случайных элементов массива в пределах параметров.
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
// Метод ввода значений юзером с поверкой введёного.
int InputIntNumberTryParse()
{
    MSG();
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
// Сообщенька :)
void MSG ()
{
    Console.WriteLine("You must specify the number of array elements.");
}