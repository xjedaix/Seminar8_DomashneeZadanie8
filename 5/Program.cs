// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

class Program {
    static void Main() {
        int[,] array = new int[4, 4]; // создаем массив размером 4 x 4

        int value = 1; // начальное значение для заполнения массива
        int row = 0; // текущая строка
        int col = 0; // текущий столбец
        int maxRow = array.GetLength(0) - 1; // максимальная строка
        int maxCol = array.GetLength(1) - 1; // максимальный столбец

        while (value <= array.GetLength(0) * array.GetLength(1)) {
            for (int i = col; i <= maxCol; i++) {
                array[row, i] = value++;
            }
            for (int i = row + 1; i <= maxRow; i++) {
                array[i, maxCol] = value++;
            }
            if (row < maxRow && col < maxCol) {
                for (int i = maxCol - 1; i >= col; i--) {
                    array[maxRow, i] = value++;
                }
                for (int i = maxRow - 1; i > row; i--) {
                    array[i, col] = value++;
                }
            }
            row++;
            col++;
            maxRow--;
            maxCol--;
        }

        // выводим массив на экран
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}