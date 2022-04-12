// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива(в пределах всего массива).

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

int[,] Sortirovka(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) ; j++)
        {
            int pos = j;
            {
                for (int k = j ; k < matr.GetLength(1); k++)
                {
                    if (matr[i, k] > matr[i, pos])
                    {
                        pos = k;
                    }
                }
                int buff = matr[i, j];
                matr[i, j] = matr[i, pos];
                matr[i, pos] = buff;
            }

        }
    }
    return matr;
}



int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintArray(Sortirovka(matrix));




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void MinString(int[,] matr)
// {
//     int numberStr=1;
//     int min=0;
//     for (int j = 0; j < matr.GetLength(1); j++) 
//         {
//             min += matr[0, j]; 
//         }
//     for (int i = 1; i < matr.GetLength(0); i++) 
//     {
//         int sum=0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sum += matr[i, j];
//         }
//         if (sum<min) 
//         {
//             min=sum;
//             numberStr=i+1;
//         }
//     }
//     Console.WriteLine($"строка с наименьшей суммой элементов {numberStr}"); 
// }

// int[,] matrix = new int[5, 3];
// FillArray(matrix);
// PrintArray(matrix);
// MinString(matrix);