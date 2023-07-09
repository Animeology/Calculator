public class Calculator
{
    public static void Main(string[] args)
    {
        Run();
    }

    public static void Run()
    {
        Console.WriteLine("Input two numbers and the operation (+, -, *, /, %)");

        float x = Convert.ToSingle(Console.ReadLine());
        char op = Convert.ToChar(Console.ReadLine()!);
        float y = Convert.ToSingle(Console.ReadLine());

        Calculate(x, op, y);
    }

    public static void Calculate(float x, char op, float y)
    {
        switch (op)
        {
            case '+':
                Addition(x, op, y);
                break;
            case '-':
                Subtraction(x, op, y);
                break;
            case '*':
                Multiplication(x, op, y);
                break;
            case '/':
                Division(x, op, y);
                break;
            case '%':
                Modulus(x, op, y);
                break;
            default:
                Console.WriteLine("Not a valid operation!");
                break;
        }
    }
    static void Addition(float x, char op, float y)
    {
        Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x + y);
    }

    static void Subtraction(float x, char op, float y)
    {
        Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x - y);
    }

    static void Multiplication(float x, char op, float y)
    {
        Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x * y);
    }

    static void Division(float x, char op, float y)
    {
        Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x / y);
    }

    static void Modulus(float x, char op, float y)
    {
        Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x % y);
    }
}