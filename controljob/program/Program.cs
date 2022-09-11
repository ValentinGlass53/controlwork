/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив изс трок,
длинна которых меньше либо равна трём.. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами!
*/

string[] array = { "hello", "2", "world", "Russia", "kazan" };
int lenNewArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lenNewArray++;
    }
}




string[] resultArray = new string[lenNewArray];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[count] = array[i];
        count++;
    }
}

// Вывести значения массива в терминал
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + " ");
}