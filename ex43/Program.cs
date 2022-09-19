// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.WriteLine(
    СalculationСoordinate(
        InputNumbers()));


double[] InputNumbers()
{
    Console.WriteLine("Введите b1, k1, b2 и k2, значения вводятся через пробел");
    string[] parts = Console.ReadLine()!.Split(' ');
    double[] numbers = new double[parts.Length];
    for (int i = 0; i < parts.Length; i++)
        numbers[i] = double.Parse(parts[i]);
    return numbers;
}

string СalculationСoordinate(double[] arr)
{
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];

    if (k1 == k2 && b1 == b2)
    {
        return "прямые совпадают. все точки пересекаются";
    }
    else if (k1 == k2)
    {
        return "Прямые параллельны, нет точки пересечения";
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        return $"x = {x}, y = {y}";
    }
}

