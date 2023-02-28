int ReadInt (string argument)
{
Console.WriteLine($"Input {argument}");
int result = 0;
while (!int.TryParse(Console.ReadLine(), out result))
{
    Console.WriteLine ("Try again");
}
return result;
}
double [,] CreateTwoDimensionArray (int firstLength, int twoLength)
{
    double [,] result = new double [firstLength, twoLength];
    Random rnd = new Random ();

    for (int i = 0; i < result.GetLength(0); i ++)
    {
            for (int j = 0; j < result.GetLength(1); j ++)
            {
              result [i, j] = Math.Round (rnd.NextDouble() * 100, 2);
            }
    }
    return result;
}

string TwoDimensionArrayToString (double [,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i ++)
    {
            for (int j = 0; j < array.GetLength(1); j ++)
            {
                result += $"{array [i, j]} ";
            }
            result += Environment.NewLine;
    }
    return result;
}

double [,] array =  CreateTwoDimensionArray (ReadInt  ("firstLength"), ReadInt  ("twoLength"));
Console.WriteLine(TwoDimensionArrayToString (array));