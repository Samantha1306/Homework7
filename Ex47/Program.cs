// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

try
{
Console.Write("Укажите, сколько строк будет в массиве (введите натуральное число): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} \t" );
    }
    Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);


}

catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}