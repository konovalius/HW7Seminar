// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int numRows = SetNumber("Введите количество строк:");
int numColumns = SetNumber("Введите количество столбцов:");

int numMaxValue = SetNumber("Максимальное число:");
int numMinValue = SetNumber("Минимальное число:");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
MediumOfColumns(matrix);


int SetNumber(string numberName)
{
    Console.Write(numberName);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] GetMatrix (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix [i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void MediumOfColumns(int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        double res = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res += matrix[i, l];
        }
        Console.Write($"{Math.Round(res/matrix.GetLength(0), 2)}"+" ; ");
    }
    Console.WriteLine();
}
    
void Print(int [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}