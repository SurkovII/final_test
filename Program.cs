/* 
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
**Примеры**:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
void FillArray(string[] collection)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"[{i}] "); ;
        collection[i] = Console.ReadLine()!;
    }

}
void PrintArray(string[] Array3)
{
    Console.Write("[");
    for (int i = 0; i < Array3.Length; i++)
    {
        Console.Write(Array3[i]);
        if (i != Array3.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write($"] ");
}
string[] FindStringOfThreeSymbol(string[] threeSymbol, int sizeElementsArray)
{
    int count = 0;
    string symbol = "";
    for (int i = 0; i < threeSymbol.Length; i++)
    {
        symbol = threeSymbol[i];
        if (symbol.Length <= sizeElementsArray)
        {
            count++;
        }
    }
    string[] Array2 = new string[count];
    int z = 0;
    for (int j = 0; j < threeSymbol.Length; j++)
    {
        symbol = threeSymbol[j];
        if (symbol.Length <= sizeElementsArray)
        {
            Array2[z] = symbol;
            z++;
        }
    }
    return Array2;
}

try
{
    Console.Write("Введите размер массива ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[sizeArray];
    FillArray(array);
    string[] Array2 = FindStringOfThreeSymbol(array, 3);
    PrintArray(array);
    Console.Write("->");
    PrintArray(Array2);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Ошибка. Повторите ввод!");
}