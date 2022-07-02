/* 
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/
Console.Clear();

void FillArray(string[] collection)
{
    System.Console.Write("Введите элементы массива: ");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.Write($"[{i}] ");
        collection[i] = Console.ReadLine()!;
    }

}

void PrintArray(string[] Array3)
{
    System.Console.Write(" [");
    for (int i = 0; i < Array3.Length; i++)
    {
        System.Console.Write(Array3[i]);
        if (i != Array3.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write($"] ");
}

string[] FindStringOfThreeSymbol(string[] threeSymbol)
{

    int count = 0;
    string symbol = String.Empty;
    for (int i = 0; i < threeSymbol.Length; i++)
    {
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] Array2 = new string[count];
    count = 0;
    for (int i = 0; i < threeSymbol.Length; i++)
    {

        symbol = threeSymbol[i];
        if (symbol.Length <= 3)
        {
            Array2[count] = symbol;
            count++;
        }
    }
    return Array2;
}

System.Console.Write("Введите размер массива: ");
try
{
    int sizeArray = Convert.ToInt32(Console.ReadLine());


    string[] array = new string[sizeArray];
    FillArray(array);
    string[] Array2 = FindStringOfThreeSymbol(array);

    Console.ForegroundColor = ConsoleColor.Green;

    PrintArray(array);
    PrintArray(Array2);

    Console.ResetColor();

}

catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Не соответствие формату, повторите ввод.");
    Console.ResetColor();
}

