// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello","2","word",":-)"] -> ["2",":-)"]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] -> []

using System;
using static System.Console;

Clear();

void PrintArray(string[] inArray)
{
    Write($"[ ");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"] ");
}

string[] FetchArray(string[] inArray)
{
    string[] result = new string[] { };
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[count] = inArray[i];
            count++;
        }
    }
    return result;
}

string[] array = new string[] { "123", "156", "-2", "computer science" };
string[] array2 = FetchArray(array);
PrintArray(array);
Write("-> ");
PrintArray(array2);