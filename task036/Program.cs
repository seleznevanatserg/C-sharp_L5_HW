// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
//  [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

int [] userArray = SettingsAndGenerateArray();
PrintArrayWhisIndex(userArray);
Console.WriteLine($"{SumNumbersWithUnevenIndex (userArray)} - sum numbers with uneven index in array");



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
// Метод для установления конфиг и генерации одномерного массива со случайными значениями.
int[] SettingsAndGenerateArray()
{
    Console.WriteLine("Welcom, user. It's module settings for one-dimensional array.");
    Console.WriteLine("Follow the instructions.");

    Console.WriteLine("You must specify the number of array elements.");
    int length = InputIntNumberTryParse();
    if (length == 0 || length == 1) // Не даёт создать юзеру массив с 0 или 1 элементом (т.к. диапазон).
    {
        length = 2;
    }
    if (length < 0)     // Изменяет на положительное, если юзер ввёл отрицательное значение длины массива.
    {
        length = length * -1;
    }
    Console.WriteLine("You must specify minimum value for generate array.");
    int min = InputIntNumberTryParse();
    Console.WriteLine("You must specify maximum value for generate array.");
    int max = InputIntNumberTryParse();
    if (min > max)  // Меняет местами мин. и макс. значения диапазона, если юзер ввёл не так границы диапазона (потому что генерирует с помощью Next).
    {
        int b = min;
        min = max;
        max = b;
    }

    int [] array = GenerateArray(min, max, length);
    return array;
}
// Метод подсчёта суммы значений массива, имеющих нечётый индекс.
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
// Печать элементов массива с индексом элемента.
void PrintArrayWhisIndex(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"({array[i]})[{i}] ");
    }
    Console.WriteLine();
}