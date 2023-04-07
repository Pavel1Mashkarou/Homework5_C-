/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0


*/

System.Console.WriteLine("Введите размер массива:");
int Len = int.Parse(Console.ReadLine());
int [] CreateMas(int Len)
{
    int[] Mas = new int[Len];
    for (int i = 0; i < Mas.Length; i++)
    {
        Mas[i] = new Random().Next(-1000, 1000);
    }
    return Mas;
}

int[] Mas = CreateMas(Len);

void PrintMas(int[] Mas)
{
    int Sum = 0;
    System.Console.Write("[");
    for (int i = 0; i < Mas.Length-1; i++)
    {
        System.Console.Write(Mas[i]+"; ");
    }
    System.Console.WriteLine(Mas[Mas.Length-1]+"]");
    for (int i = 0; i < Mas.Length; i++)
    {
        if (i%2 == 1)
        {
            Sum = Sum + Mas[i];
        }
    }
    System.Console.WriteLine($"Сумма элементов с нечётным индексом равна: {Sum}");
}

PrintMas(Mas);
