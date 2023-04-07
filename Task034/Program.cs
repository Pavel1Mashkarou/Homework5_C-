/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

System.Console.WriteLine("Введите размер массива:");
int Len = int.Parse(Console.ReadLine());
int [] CreateMas(int Len)
{
    int[] Mas = new int[Len];
    for (int i = 0; i < Mas.Length; i++)
    {
        Mas[i] = new Random().Next(100, 1000);
    }
    return Mas;
}

int[] Mas = CreateMas(Len);

void PrintMas(int[] Mas)
{
    int Kol = 0;
    System.Console.Write("[");
    for (int i = 0; i < Mas.Length-1; i++)
    {
        System.Console.Write(Mas[i]+"; ");
    }
    System.Console.WriteLine(Mas[Mas.Length-1]+"]");
    for (int i = 0; i < Mas.Length; i++)
    {
        if (Mas[i] % 2 == 0)
        {
            Kol++;
        }
    }
    System.Console.WriteLine($"Количество четных чисел в массиве: {Kol}");
}

PrintMas(Mas);

