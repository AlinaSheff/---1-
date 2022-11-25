// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых мньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[m];
string[] newArray = new string[Array.Length];

void FillArray(string[] Array)
{
int count = 1;    
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите {count} элемент массива: ");
    Array[i] = Console.ReadLine();
    count ++;
}
}

void PrintArray(string[] Array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}