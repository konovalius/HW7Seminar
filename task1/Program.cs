//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int numRows = SetNumber("Введите количество строк: ");
int numColumns = SetNumber("Введите количество столбцов: ");
var numMaxValue = SetNumber("Максимальное число: ");
var numMinValue = SetNumber("Минимальное число: ");


var matrix = GetMatrixDouble(numRows, numColumns,numMaxValue,numMinValue );
Print(matrix);

int SetNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


double[,] GetMatrixDouble(int rows, int columns, double min, double max)
{
    
    double[,] res = new double[rows,columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int l=0;l<columns;l++)
        {
        res[i,l] = random.NextDouble() * (max - min) + min; 
        res[i,l] = Math.Round(res[i,l],2);
        }
    }
    return res;
}


void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + "     ");
        }
        Console.WriteLine();
    }
}