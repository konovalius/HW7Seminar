int size = 4;
int[,] Massiv = new int[size, size];
int fill = 1;
int i = 0;
int j = 0;



while (fill <= Massiv.GetLength(0) * Massiv.GetLength(1))
{
    Massiv[i, j] = fill;
    fill++;
    if (i <= j+1 && i + j < Massiv.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= Massiv.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > Massiv.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

Print(Massiv);

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (matrix[i, l] < 10) Console.Write(" " + matrix[i, l] + " ");
            else Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}