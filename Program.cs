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
        char op = Convert.ToChar(Console.ReadLine());
        float y = Convert.ToSingle(Console.ReadLine());

        Calculate(x, op, y);
    }

    public static void Calculate(float x, char op, float y)
    {
        switch (op)
        {
            case '+':
                Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x + y);
                break;
            case '-':
                Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x - y);
                break;
            case '*':
                Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x * y);
                break;
            case '/':
                Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x / y);
                break;
            case '%':
                Console.WriteLine("{0}{1}{2} = {3}", x, op, y, x % y);
                break;
            default:
                Console.WriteLine("Not a valid operation!");
                break;
        }
    }
}