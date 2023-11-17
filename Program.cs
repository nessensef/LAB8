Console.WriteLine("x и y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
try
{
    int z = x / y;
}
catch (DivideByZeroException) when (y == 0)
{
    Console.WriteLine("Ошибка");
}
try
{
    int z = x / y;
    if (x == 0)
    {
        throw new Exception("x ");
    }
    else
    {
        Console.WriteLine($":{z}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}