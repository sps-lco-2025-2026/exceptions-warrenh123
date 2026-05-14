// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}
catch(IndexOutOfRangeException e)
{
    Console.WriteLine($"Index out of range {e.Message}");
}



// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}
catch(NullReferenceException e)
{
    Console.WriteLine($"Caught error: {e.Message}");
}



// Snippet C
try
{
    int x = int.MaxValue;
    checked { x = x + 1; } // checked enforces overflow detection
}
catch(OverflowException e)
{
    Console.WriteLine($"Error caught: {e.Message}");
}