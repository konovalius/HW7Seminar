// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int indRow = SetNumber("Введите номер строки элемента:");
int indColumn = SetNumber("Введите номер столбца элемента:");

int numRows=8;
int numColumns=8;
int numMinValue=10;
int numMaxValue=99;
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);

Print (matrix);
Console.WriteLine();
SearchValue(matrix, indRow, indColumn)   ;
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

int SetNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void SearchValue (int[,] matrix, int row, int column)
{
    if (row >matrix.GetLength(0) || column > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else 
    {
       Console.WriteLine($"Искомый элемент: {matrix[row-1,column-1]}");
    }
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
       




