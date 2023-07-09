namespace Calculator
{
    public class CalculatorTests
    {
        static void Main(string[] args)
        {
            AdditionTest();
            SubtractionTest();
            MultiplicationTest();
            DivisionTest();
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

        static void MultiplicationTest()
        {
            float x = 5;
            float y = 5;
            char mockOp = '*';

            var expected = x * y;
            var actual = CalculatorApp.Multiplication(x, mockOp, y);

            if (actual == expected)
            {
                Console.WriteLine("Multiplication Test Succeeded");
            }
            else
            {
                Console.WriteLine("Multiplication Test Failed");
            }
        }

        static void DivisionTest()
        {
            float x = 100;
            float y = 5;
            char mockOp = '/';

            var expected = x / y;
            var actual = CalculatorApp.Division(x, mockOp, y);

            if (actual == expected)
            {
                Console.WriteLine("Division Test Succeeded");
            }
            else
            {
                Console.WriteLine("Division Test Failed");
            }
        }

    }
}
