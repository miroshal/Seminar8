// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreaateArray(int m = 5, int n = 5)
{
    int[,] array = new int[m, n];
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(0, 10);
        }
    }
    return coll;
}

int[,] MatrixMultiplication(int[,] m1, int[,] m2)
{
    int[,] resMatrix = CreaateArray(m1.GetLength(0), m2.GetLength(1));
    if (m1.GetLength(1) == m2.GetLength(0))
    {
        int[] resRows = new int[10];

        for (int t = 0; t < m1.GetLength(1); t++)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    resMatrix[t, k] += m1[t, i] * m2[i, j];
                    k++;
                }
            }
        }
    }
    return resMatrix;
}

void Main()
{

    int[,] mat1 = CreaateArray(2, 2);
    mat1 = FillArrayRandom(mat1);
    PrintArr(mat1);
    System.Console.WriteLine();

    int[,] mat2 = CreaateArray(2, 3);
    mat2 = FillArrayRandom(mat2);
    PrintArr(mat2);
    System.Console.WriteLine();

    PrintArr(MatrixMultiplication(mat1, mat2));
}

Main();