using ConsoleApp20;


public class program
{
    public static void Main()
    {
        Arithmetic arithmetic1 = new Arithmetic();
        arithmetic1.A = 20;
        arithmetic1.B = 10;

       Arithmetic arithmetic2 = new Arithmetic();
        arithmetic2.sub(arithmetic1);



        //arithmetic.Add (10,20); 

        int result;
        arithmetic2.mul(10, 20, out result);
        Console.WriteLine($"Multiplication of 10 and  30 is = {result}");

        int result1 = 10;
        arithmetic2.Div(20,10,ref result1);
        Console.WriteLine($"Result = {result1}");
    }
}