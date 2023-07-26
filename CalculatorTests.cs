namespace CalculatorTests
{
    using Calculator;

    public class CalculatorTests
    {
        public static void RunAllTests()
        {
            AdditionTest();
            SubtractionTest();
            MultiplicationTest();
            DivisionTest();
            ModulusTest();
        }

        static void AdditionTest()
        {
            float x = 10;
            float y = 20;
            char mockOp = '+';

            var expected = x + y;
            var actual = CalculatorApp.Addition(x, mockOp, y);

            if(actual != expected)
            {
                throw new Exception("Addition Test Failed");
            }
        }

        static void SubtractionTest()
        {
            float x = 20;
            float y = 10;
            char mockOp = '-';

            var expected = x - y;
            var actual = CalculatorApp.Subtraction(x, mockOp, y);

            if (actual != expected)
            {
                throw new Exception("Subtraction Test Failed");
            }
        }

        static void MultiplicationTest()
        {
            float x = 5;
            float y = 5;
            char mockOp = '*';

            var expected = x * y;
            var actual = CalculatorApp.Multiplication(x, mockOp, y);

            if (actual != expected)
            {
                throw new Exception("Multiplication Test Failed");
            }
        }

        static void DivisionTest()
        {
            float x = 100;
            float y = 5;
            char mockOp = '/';

            var expected = x / y;
            var actual = CalculatorApp.Division(x, mockOp, y);

            if (actual != expected)
            {
                throw new Exception("Division Test Failed");
            }
        }

        static void ModulusTest()
        {
            float x = 100;
            float y = 5;
            char mockOp = '%';

            var expected = x % y;
            var actual = CalculatorApp.Modulus(x, mockOp, y);

            if (actual != expected)
            {
                throw new Exception("Modulus Test Failed");
            }
        }
    }
}
