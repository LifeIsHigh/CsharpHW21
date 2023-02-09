// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter value = number of Rows : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value = number of Columns : ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[x, y];
double ArithmeticAverage = 0;
int Temp = 0;
double SumMatrixColumn = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Matrix[i, j] = new Random().Next(-10, 11);
        Console.Write($"{Matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");
void SRCArithmeticAverage(int[,] Matrix)
{
    while (Temp < y)
    {
        for (int i = 0; i < x; i++)
        {
            if (i == 0)
            {
                SumMatrixColumn = 0;
            }
            SumMatrixColumn += (Matrix[i, Temp]);
            ArithmeticAverage = SumMatrixColumn / (i + 1);
        }
        Console.Write($"{Math.Round(ArithmeticAverage, 2)} ");
        Temp++;
    }
}

SRCArithmeticAverage(Matrix);