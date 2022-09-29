int SumOfDigits(int num)
{
    int result = 0;
    while (Math.Abs(num) > 0)
    {
        result = result + num % 10;
        num = num /10;
    }
    return result;
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sum = SumOfDigits(number);
Console.WriteLine(Math.Abs(sum));
