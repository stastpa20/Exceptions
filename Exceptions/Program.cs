int cisloA = 0;
int cisloB = 0;

bool aJo = int.TryParse(Console.ReadLine(), out cisloA);
bool bJo = int.TryParse(Console.ReadLine(), out cisloB);

/*try
{
    Console.WriteLine(cisloA / cisloB);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.ReadLine();
}*/

try
{
    if(cisloB == 0) { throw new MyException("deleni nulou"); }
    Console.WriteLine(cisloA / cisloB);
}
catch (MyException ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}

public class MyException : Exception
{
    public MyException()
    {
    }

    public MyException(string message)
        : base(message)
    {
    }

    public MyException(string message, Exception inner)
        : base(message, inner)
    {
    }

}


