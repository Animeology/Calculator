namespace Calculator
{
    public class CalculatorTests
    {
        static void Main(string[] args)
        {
            AdditionTest();
            SubtractionTest();
        }

        static void AdditionTest()
        {
            float x = 10;
            float y = 20;
            char mockOp = '+';

            var expected = x + y;
            var actual = CalculatorApp.Addition(x, mockOp, y);

            if(actual == expected)
            {
                Console.WriteLine("Addition Test Succeeded");
            }
            else
            {
                Console.WriteLine("Addition Test Failed");
            }
        }

        static void SubtractionTest()
        {
            float x = 20;
            float y = 10;
            char mockOp = '-';

            var expected = x - y;
            var actual = CalculatorApp.Subtraction(x, mockOp, y);

            if (actual == expected)
            {
                Console.WriteLine("Subtraction Test Succeeded");
            }
            else
            {
                Console.WriteLine("Subtraction Test Failed");
            }
        }
    }
}
