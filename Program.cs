
string[] CreateStringArray(byte size) // Создание string-массива заданного размера
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"\n" + "Введите элемент строкового массива -> ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
string[] ChooseElementsFromAarrayByLength(string[] array, byte lengthElmnt) // Выбрать из 
// строкового массива стрроки нужной длины и сформировать из них новый массив
{
    int count = 0;
    string[] arrResult = { };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthElmnt)
        {
            count++;
            string[] temp = new string[count];
            for (int j = 0; j < count - 1; j++)
            {
                temp[j] = arrResult[j];
            }
            arrResult = temp;
            arrResult[count - 1] = array[i];
        }
    }
    return arrResult;
}

void PrintArray(string[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine("\b\b]\n");
}


Console.Write("\n" + "Задайте длину массива -> ");
byte arraysize = Convert.ToByte(Console.ReadLine());
string[] sourceArray = CreateStringArray(arraysize);

Console.Write("\n" + "Задайте ограничение длины строковых элементов нового массива -> ");
byte lengthElement = Convert.ToByte(Console.ReadLine());
string[] newarr = ChooseElementsFromAarrayByLength(sourceArray, lengthElement);
Console.Write("\n" + "Введен исходный массив -> ");
PrintArray(sourceArray);
if (newarr.Length != 0)
{
    Console.Write("Создан новый массив -> ");
    PrintArray(newarr);
}
else Console.WriteLine($"В исходном массиве нет строк длиной не более {lengthElement}" +
                        " символов.\n" + "Новый массив пуст.\n");