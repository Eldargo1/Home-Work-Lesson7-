// Задайте произвольный массив. Выведете его элементы, начиная с конца.  
//Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int [size];

Console.WriteLine("Введите  элементы массива");
ReadArray(array, 0 , size);
Console.WriteLine("Элементы массива в обратном порядке");
PrintArrayInReverse(array, size - 1);

void ReadArray(int[] array, int index, int size)
{
    if(index < size)
    {
        array[index] = int.Parse(Console.ReadLine());
        ReadArray(array, index+ 1, size);
    }
}

void PrintArrayInReverse(int[] array, int index)
{
    if(index >= 0)
    {
        Console.WriteLine(array[index]);
        PrintArrayInReverse(array, index - 1);
    }
}