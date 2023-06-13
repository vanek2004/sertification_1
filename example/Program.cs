// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayOne = CreateArray(size);
PrintArray(arrayOne);

string[] arrayTwo = new string[arrayOne.Length];
FindString(arrayOne, arrayTwo);
PrintArray(arrayTwo);


string[] CreateArray(int length)
{
    string[] arrOne = new string[length];
    for (int i = 0; i < arrOne.Length; i++)
    {
        arrOne[i] = Console.ReadLine();
    }
    return arrOne;
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

void FindString (string[] arrOne, string[] arrTwo)
{
    int count = 0;
    for (int i = 0; i < arrOne.Length; i++)
    {
        if (arrOne[i].Length <= 3)
        {
            arrTwo[count] = arrOne[i];
            count++;
        }
    }
}

