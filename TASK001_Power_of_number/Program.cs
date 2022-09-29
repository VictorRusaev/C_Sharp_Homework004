int Power(int num1, int num2)
{
    int index = 2;
    int result = num1;
    while(index <= num2)
    {
        result = result * num1;
        index++;
    }
    return result;
}

Console.Clear();

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int C = Power(A, B);
Console.WriteLine(C);