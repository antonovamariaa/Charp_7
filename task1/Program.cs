﻿double[,] Fillmatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(min, max) + rand.NextDouble(), 2); ;
        }
    }
    return matrix;
}

void Printmatrix(double[,] matrix)
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

//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
double[,] matrix = Fillmatrix(rows, columns, minnum, maxnum);

Printmatrix(matrix);