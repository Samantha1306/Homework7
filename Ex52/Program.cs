// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

try
{
    Console.Write("Укажите, сколько строк будет в массиве (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число): ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[m, n];

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void Average(int[,] matr)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double average = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                average = average + matr[i, j];
            }
            average = average / m;
            Console.Write($"Среднее арифметическое столбца {j+1} равно: {average:F2}. ");
        }
    }
    FillArray(matrix);
    PrintArray(matrix);
    Average(matrix);
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}