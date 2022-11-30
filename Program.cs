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

void FillArray(string[] array) // заполняем массив и выводим его
{

    for(int i = 0; i<array.Length;i++)
    {
        array[i] = InpMessage($"Введите значение {i+1} элемента: ");
    }
}


void FilterArray(string[] array, string[] array2) //фильтруем массив по условию x<=3 символа и собираем новый
{
    
}


//end of methods

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] MyArray = new string[size];
FillArray(MyArray);
