/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
   лучше обойтись исключительно массивами.
*/
﻿using static System.Console;

// Ввод строки из консоли
string EnterString()
{
    WriteLine("Введите слова через пробел");
    return ReadLine()!;
}

// переоброзование строки в массив
string[] StringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}

// создаём массив меньше или равно 3-ём символам
string[] CreatMaxThreeDigitArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}
// печать массива
void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string str = EnterString();
string[] array = StringToArray(str);
string[] targetArray = CreatMaxThreeDigitArray(array);
WriteLine();
PrintArray(targetArray);




