//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.WriteLine("Введите число M");
int userFirstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int userSecondnum = int.Parse(Console.ReadLine());
int result = Ackermann(userFirstNum, userSecondnum);
Console.WriteLine(result);

int Ackermann(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return Ackermann(m -1, 1);
    }
    else 
    {
        return Ackermann(m - 1, Ackermann(m , n - 1));
    }
}
