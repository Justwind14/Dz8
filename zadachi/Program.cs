Task54();
// Task56();
// Task58();

void Task54()
{
    //     Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:

    Console.Clear();
    Console.Write("задайте количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("задайте количество строк в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    SortArray(matrix);
    Console.WriteLine("Отсортированные элементы строк массива по убыванию:");
    PrintArray(matrix);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            array[i, j] = random.Next(0, 30);
        }
    }
}

void PrintArray(int[,] array)
{
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            for (int k = j; k < sizeColumnsArray; k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}

void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Random plsNoCube = new Random();
    int rows = plsNoCube.Next(2, 7);
    int columns = plsNoCube.Next(2, 7);
    if (rows == columns) { columns++; }
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine($"Наименьшая сумма элементов у {LowSummElements(matrix)}й строки масива");
}

int LowSummElements(int[,] arr)
{
    int rowsSize = arr.GetLength(0);
    int columnsSize = arr.GetLength(1);
    int minSummRow = 0;
    int MinSumm = 29 * columnsSize; // число 29 - это максимальное рандомное значение элемента массива в рандомайзере. Если меняем условие заполения массива, меняем и тут значение.
    for (int i = 0; i < rowsSize; i++)
    {
        int sumRowElements = 0;
        for (int j = 0; j < columnsSize; j++)
        {
            sumRowElements = sumRowElements + arr[i, j];
        }
        if (sumRowElements < MinSumm)
        {
            MinSumm = sumRowElements;
            minSummRow = i + 1;
        }
    }
    return minSummRow;
}

void Task58()
{
    //     Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
    //     Например, на выходе получается вот такой массив:
    //      01 02 03 04
    //      12 13 14 05
    //      11 16 15 06
    //      10 09 08 07
    int size = 4;
    int[,] matrix = new int[size, size];
    FillSpiralArray(matrix);
    PrintArray(matrix);
}

void FillSpiralArray(int[,] cube)
{
    int sizeRowsCube = cube.GetLength(0);
    int sizeColumnsCube = cube.GetLength(1);
    int numb = 0;
    for (int l = 0; l < sizeColumnsCube; l++)
    {
        cube[0, l] = numb + 1;
        numb++;
    }
    for (int k = 1; k < sizeRowsCube; k++)
    {
        cube[k, 3] = numb + 1;
        numb++;
    }
    for (int j = 2; j > -1; j--)
    {
        cube[3, j] = numb + 1;
        numb++;
    }
    for (int i = 2; i > 0; i--)
    {
        cube[i, 0] = numb + 1;
        numb++;
    }
    for (int m = 1; m < sizeColumnsCube - 1; m++)
    {
        cube[1, m] = numb + 1;
        numb++;
    }
    for (int n = 2; n > 0; n--)
    {
        cube[2, n] = numb + 1;
        numb++;
    }
}

