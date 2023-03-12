// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreaateArray(int m = 30, int n = 30)
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
            System.Console.Write($"{array[i, j],3}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArray(int[,] arr)
{

    int num = 1;
    int size = arr.GetLength(1);

    for (int delta = 0; delta < size - 2; delta++)
    {
        for (int i = 0 + delta; i < size - delta; i++)
        {
            arr[0 + delta, i] = num;
            num++;
        }
        num--;

        for (int i = 0 + delta; i < size - delta; i++)
        {
            arr[i, (size - 1) - delta] = num;
            num++;
        }

        num--;
        for (int i = size - 1 - delta; i >= 0 + delta; i--)
        {
            arr[(size - 1) - delta, i] = num;
            num++;
        }
        num--;
        for (int i = size - 1 - delta; i >= 1 + delta; i--)
        {
            arr[i, 0 + delta] = num;
            num++;
        }
    }
    return arr;
}

void Main()
{
    int n = Prompt("введи размер спирали: ");
    int[,] arr = CreaateArray(n, n);
    arr = FillArray(arr);
    PrintArr(arr);
}

Main();