// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;

class Program {
    static void Main() {
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // создаем результирующую матрицу

        for (int i = 0; i < matrix1.GetLength(0); i++) { // проходим по каждой строке первой матрицы
            for (int j = 0; j < matrix2.GetLength(1); j++) { // проходим по каждому столбцу второй матрицы
                for (int k = 0; k < matrix1.GetLength(1); k++) { // перемножаем элементы в строке первой матрицы и столбце второй матрицы
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // выводим результат на экран
        for (int i = 0; i < resultMatrix.GetLength(0); i++) {
            for (int j = 0; j < resultMatrix.GetLength(1); j++) {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}