// int[,] GetMatrix(int m, int n, int k)
// {
//     int[,] matrix = new int[m, n];
//     int currentValue = 1; //start
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = currentValue;
//             // matrix[0,0] = currentValue
//             // matrix[0,1] = currentValue
//             currentValue += k;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr) // [кол-во строк, кол-во столбцов]
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintMatrix(GetMatrix(5, 5, 2));


