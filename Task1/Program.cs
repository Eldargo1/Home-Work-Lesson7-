// Задайте значения M и N. Напишите программу,  
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число M");
int userFirstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int userSecondnum = int.Parse(Console.ReadLine());

SetSumNum(userFirstNum, userSecondnum);

void SetSumNum(int start, int end)
{
    if(start > end)
    {
        return;
    }

    Console.Write(start+ " ");
    start++;
    SetSumNum(start, end);
}
