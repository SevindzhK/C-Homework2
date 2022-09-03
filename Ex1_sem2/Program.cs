// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter three-digit number: "); 
int number = Convert.ToInt32(Console.ReadLine());

int GetSecondDigit(int num)
{
    int result = num / 10 % 10;
    return result;
}
Console.WriteLine(GetSecondDigit(number)); 
