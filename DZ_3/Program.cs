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

int [,] CreateTwoDimensionArray (int firstLength, int twoLength)
{
    int [,] result = new int [firstLength, twoLength];
    Random rnd = new Random ();

    for (int i = 0; i < result.GetLength(0); i ++)
    {
            for (int j = 0; j < result.GetLength(1); j ++)
            {
                result [i, j] = rnd.Next(10,100);
            }
    }
   return result;
}

string TwoDimensionArrayToString (int [,] array)
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
void MiddleSum (int [,] array)
{   
    for (int j = 0; j < array.GetLength(1); j ++)
    {   
        double sum = 0;
            for (int i = 0; i < array.GetLength(0); i ++)
            
            {   
                sum = sum + array [i,j]; 
            }
        Console.Write($" {sum / array.GetLength(0)}  ");
}
}

int firstLength = ReadInt ("Введите кол-во строк");
int twoLength = ReadInt ("Введите кол-во столбцов");
int [,] array = CreateTwoDimensionArray (firstLength, twoLength);
Console.WriteLine(TwoDimensionArrayToString (array));
MiddleSum (array);