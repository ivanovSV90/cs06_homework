// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = InputNumbers();
PrintArray(array);
System.Console.WriteLine($"количество введенных положительных чисел = {SearchPositive(array)}");

int[] InputNumbers()
{
    System.Console.WriteLine("Введите числа через пробел");
    string[] parts = Console.ReadLine()!.Split(' ');
    int[] numbers = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
        numbers[i] = int.Parse(parts[i]);
    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine();
}

int SearchPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            count++;
        }
    }
    return count;
}