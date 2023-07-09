namespace Calculator
{
    public class CalculatorTests
    {
        static void Main(string[] args)
        {
            AdditionTest();
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
        }
    }
}
