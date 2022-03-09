namespace Calculations
{
    public static class Calculator
    {
        public static double Add(double numberOne, double numberTwo)
        {
            double value;
            value = numberOne + numberTwo;
            return value;
        }

        public static double Subtract(double numberOne, double numberTwo)
        {
            double value;
            value = numberOne - numberTwo;
            return value;
        }

        public static double Multiply(double numberOne, double numberTwo)
        {
            double value;
            value = numberOne * numberTwo;
            return value;
        }

        public static double Divide(double numberOne, double numberTwo)
        {
            double value;
            value = numberOne / numberTwo;
            return value;
        }
        public static double Power(double numberOne, double numberTwo)
        {
            double value;
            value = Math.Pow(numberOne, numberTwo);
            return value;
        }
        public static double SquareRoot(double numberOne)
        {
            double value;
            value = Math.Sqrt(numberOne);
            return value;
        }
    }
}