// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.
// int size = 12;
// int[] array = new int[size];

//  int[] array = CreatArray(12,-9,9);
//  System.Console.WriteLine($"Массив : [{String.Join("; " , array)}]"); // String - выводит
// // элементы массива в консоли по отдельности => Join - соединяет элементы в строку
// // с помощью указанного знака "; "

// // Создание массива 
// // 3 параметра : 1 параметр - размер массива size
// // 2 параметр : нижняя граница рандом (-9), верхняя граница рандома(9)

// int[] CreatArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int [size]; // создание массива на size элементов
//     // если size = 12, то масив состоит из 12 нулей
//     for ( int i=0; i< size ; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result; // Вернули массив на size элементов, заполненный числами
//     // от minValue до maxValue
// }


// int sumPositive = 0; // Сумма положительных чисел
// int sumNegative = 0; // Сумма отрицательных чисел
// int size = array.Length;
// for (int i = 0; i < size; i++)
// {
//     if (array[i] > 0)
//     {
//         //sumPositive = sumPositive + array[i];
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i]; // sumNegative = sumNegative + array[i]
//     }
// }
// Console.WriteLine($"Сумма положительных чисел: {sumPositive}, отрицательных чисел: {sumNegative} ");

//==================================
// Перевернуть массив , положительные значения в массиве сделать отрицательными и наоборот

// int[] array = GetArray(12, -9, 9);

// Создание массива
// 3 параметра: 1 параметр - размер массива size
// 2 параметр: нижняя граница рандома (-9), верхняя граница рандома (9) 
// int[] GetArray(int size, int minValue, int maxValue) // Создание массива
// {
//     int[] result = new int[size]; // Создание массива на size элементов
//     // Если size = 12, то массив состоит из 12 нулей
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result; // Вернули массив на size элементов, заполненный числами
//     // от minValue до maxValue
// }

// int[] InverseArray(int[] inputArray)
// {
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         inputArray[i] *= (-1); // inputArray[i] = inputArray[i] * (-1)
//     }
//     return inputArray;
// }
// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// Console.WriteLine($"Перевернутый массив:: [{String.Join("; ", InverseArray(array))}]");

//===========================

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = GetArray(12, -9, 9);
// System.Console.WriteLine("Введите число: ");
// int foundNumber = Convert.ToInt32(Console.ReadLine());
// int[] GetArray(int size, int minValue, int maxValue) // Создание массива
// {
//     int[] result = new int[size]; // Создание массива на size элементов
//     // Если size = 12, то массив состоит из 12 нулей
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result; // Вернули массив на size элементов, заполненный числами
//     // от minValue до maxValue
// }
// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] == foundNumber)
//     {
//         Console.WriteLine($"число {foundNumber} есть ");
//         break;
//     }
//     else
//     {
//         Console.WriteLine($"число {foundNumber} нет ");
//     }
// }
// // Можно записать все это в логическую переменную bool

//====================

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = GetArray(15, -9, 20);
// int[] GetArray(int size, int minValue, int maxValue) // Создание массива
// {
//     int[] result = new int[size]; // Создание массива на size элементов
//     // Если size = 12, то массив состоит из 12 нулей
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result; // Вернули массив на size элементов, заполненный числами
//     // от minValue до maxValue
// }
// int sumNumber = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i]>=10 && array[i] <= 99)
//     {
//         sumNumber = sumNumber + 1;
//     }
// }
// System.Console.WriteLine(String.Join(";" ,array));
// System.Console.WriteLine(sumNumber);

//=====================
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = GetArray(15, -9, 20);
int[] GetArray(int size, int minValue, int maxValue) // Создание массива
{
    int[] result = new int[size]; // Создание массива на size элементов
    // Если size = 12, то массив состоит из 12 нулей
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}

for (int i = 0; i < array.Length; i++)
{
    
}