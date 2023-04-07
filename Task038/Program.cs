/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

System.Console.WriteLine("Введите размер массива:");
int Len = int.Parse(Console.ReadLine());
double[] CreateMas(int Len)
{
    double[] Mas = new double[Len];
    Random random = new Random();
    for (int i = 0; i < Mas.Length; i++)
    {
        Mas[i] = random.NextDouble() * 2000 - 1000; // Генерация случайного числа с дробной частью от -1000 до 1000
        Mas[i] = Math.Round(Mas[i], 2);
    }
    return Mas;
}

double[] Mas = CreateMas(Len);

double FindMax (double[] Mas)
{
    double Max = Mas[0];
    for (int i = 0; i < Mas.Length; i++)
    {
        if (Mas[i]>Max) Max = Mas[i];
    }
    return Max;
}

double FindMin (double[] Mas)
{
    double Min = Mas[0];
    for (int i = 0; i < Mas.Length; i++)
    {
        if (Mas[i]<Min) Min = Mas[i];
    }
    return Min;
}

void Magic(double[] Mas)
{
    System.Console.Write("[");
    for (int i = 0; i < Mas.Length-1; i++)
    {
        System.Console.Write(Mas[i]+"; ");
    }
    System.Console.WriteLine(Mas[Mas.Length-1]+"]");
    double Max = FindMax(Mas);
    double Min = FindMin(Mas);
    System.Console.WriteLine($"Максимальный элемент массива: {Max}");
    System.Console.WriteLine($"Минимальный элемент массива: {Min}");
    double Razn = Max - Min;
    System.Console.WriteLine($"Разница между максимальным элементом ({Max}) и минимальным элементом массива({Min}) равна: {Razn}");
}

Magic(Mas);