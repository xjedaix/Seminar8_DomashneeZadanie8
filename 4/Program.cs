// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)


using System;

class Program {
    static void Main() {
        int[,,] array = new int[2, 2, 2]; // создаем трехмерный массив размером 2 x 2 x 2
        int number = 10; // начальное значение для заполнения массива

        // заполняем массив неповторяющимися двузначными числами
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int k = 0; k < array.GetLength(2); k++) {
                    array[i, j, k] = number++;
                }
            }
        }

        // выводим массив на экран с индексами каждого элемента
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int k = 0; k < array.GetLength(2); k++) {
                    Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}