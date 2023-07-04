﻿int[,] Fillmatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1); ;
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

void CheckIndex(int[,] matrix, int ind1, int ind2)
{
    if (ind1 <= matrix.GetLength(1) && ind2 <= matrix.GetLength(0)) { System.Console.WriteLine(matrix[ind2 - 1, ind1 - 1]); }
    else { System.Console.WriteLine("no number with this index"); }
}

//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input rows: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum);
Printmatrix(matrix);
System.Console.WriteLine();
CheckIndex(matrix, Input("input columns index: "), Input("input rows index: "));