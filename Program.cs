/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа. 
Первоналчальный массив можно принять вводом, либо задать захардкодить. 
При решении коллекции не желательны, работа с массивами в приоритете.
Пример: ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

//methods
string InpMessage(string message) // просим ввести данные
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

void FillArray(string[] array) // заполняем массив
{
    for(int i = 0; i<array.Length;i++)
    {
        array[i] = InpMessage($"Введите значение {i+1} элемента: ");
    }
}

void FilterArray(string[] array) //фильтруем массив по условию x<=3 символа и собираем новый
{
    int count = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
            array[count] = array[i];
            count++;
        }
    }
    if(count>0)
    {
        Array.Resize(ref array, count);
        Console.WriteLine(array.Length);
    }
    else Console.WriteLine("Во введёном массиве нет элементов, подходящих условиям.");
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for(int i = 0;i<array.Length-1;i++)
    {
        Console.Write($"\"{array[i]}\"");
        Console.Write(", ");
    }
    Console.Write($"\"{array[array.Length-1]}\"]");
}


//end of methods

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] MyArray = new string[size];
string[] FiltredArray = new string[size];
FillArray(MyArray);
PrintArray(MyArray);
FilterArray(MyArray);
PrintArray(MyArray);

