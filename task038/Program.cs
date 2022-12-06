// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] userArray = SettingsAndGenerateArray();
PrintArray(userArray);
int result = DifferenceMaxToMinValueInArrau(userArray);
Console.WriteLine($"{result} - difference between maximum and minimum array value.");



// Метод для перебора массива в поисках макс. и мин. значения для вычисления разницы. Её же он и возвращает.
int DifferenceMaxToMinValueInArrau (int [] array)
{
    int min = array[0];
    int max = array[0];
    
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    }
    Console.WriteLine($"max = {max}; min = {min}");
    result = max - min;
    return result;
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
