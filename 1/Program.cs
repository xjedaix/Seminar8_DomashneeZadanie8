// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using System;

class Program {
    static void Main() {
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        
        for (int i = 0; i < array.GetLength(0); i++) { // проходим по каждой строке
            for (int j = 0; j < array.GetLength(1) - 1; j++) { // сравниваем элементы в строке
                for (int k = j + 1; k < array.GetLength(1); k++) {
                    if (array[i, j] > array[i, k]) { // если элементы не упорядочены по возрастанию
                        int temp = array[i, j]; // меняем местами
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        // выводим результат на экран
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = array.GetLength(1) - 1; j >= 0; j--) {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}