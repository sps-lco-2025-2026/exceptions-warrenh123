
int Divide(int a, int b)
{  
    try
    {
        Console.WriteLine("Divide Attempted");
        return a / b;
    }
    catch(DivideByZeroException ex)
    {
        throw new ArgumentException("Denominator cannot be 0", ex);
    }
}

int ReadAndDivide()
{
    Console.Write("Numerator: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Denominator: ");
    int b = int.Parse(Console.ReadLine()!);
    return Divide(a, b);
}

try
{
    Console.WriteLine(ReadAndDivide());
}
catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
}




