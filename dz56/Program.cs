// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] CreaateArray(int m = 5, int n = 7)
{
    int[,] array = new int[m, n + 1];  
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
        int sum = 0;
        for (int j = 0; j < coll.GetLength(1) - 1; j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
            sum += coll[i, j];
        }
        coll[i, coll.GetLength(1) - 1] = sum;    
    }
    return coll;
}

string FindMinRows(int[,] arr)
{
    int MinRows = arr[0, arr.GetLength(1) - 1];
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(arr[i,arr.GetLength(1) - 1] < MinRows)
        {
            MinRows = arr[i,arr.GetLength(1) - 1];
            minIndex = i;
        } 
    }
    return $" minRows value {MinRows} minIndex {minIndex}";
}

void Main()
{
    int[,] arr = CreaateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    Console.WriteLine();
    System.Console.WriteLine(FindMinRows(arr)); 
}

Main();