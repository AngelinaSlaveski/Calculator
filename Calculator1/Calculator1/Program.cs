using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator("HP-Prime");
            calculator.CalculatorBrand("The calculator's brand is: ");
            calculator.Addition(2, 58);
            calculator.Substraction(100, 258);
            calculator.Division(7, 13);
            calculator.Multiplication(420, 38);
            calculator.ToThePower(2, 3);
            calculator.Minimum(9986, 3825);
            calculator.Maximum(1025, 469);
            calculator.Comparison(25, 65);
            calculator.Square(28);
            calculator.findModulo(9, 5);

        }
        public class Calculator
        {
            public string brand;

            public Calculator(string brand)
            {
                this.brand = brand;
            }

            public void CalculatorBrand(string text)
            {
                Console.WriteLine(text + ' ' + brand);
            }
            public int Addition(int number1, int number2)
            {
                int sum = number1 + number2;
                Console.WriteLine($"The sum of the numbers {number1} and {number2} is {sum}");
                return sum;
            }
            public int Substraction(int number1, int number2)
            {
                int sub = number1 - number2;
                Console.WriteLine($"The result of the substraction of the numbers {number1} and {number2} is {sub}");
                return sub;
            }
            public float Division(int number1, int number2)
            {
                float div = number1 - number2;
                Console.WriteLine($"The result of the division of the numbers {number1} and {number2} is {div}");
                return div;
            }
            public int Multiplication(int number1, int number2)
            {
                int mult = number1 * number2;
                Console.WriteLine($"The result of the multiplication of the numbers {number1} and {number2} is {mult}");
                return mult;
            }
            public double ToThePower(double number1, double number2)
            {
                double toThePowerOf = Math.Pow(number1, number2);
                Console.WriteLine($"The result of {number1} to the power of {number2} is {toThePowerOf}");
                return toThePowerOf;
            }
            public int Minimum(int number1, int number2)
            {
                int minimum = Math.Min(number1, number2);
                Console.WriteLine($"The minimum number is {minimum}");
                return minimum;
            }
            public int Maximum(int number1, int number2)
            {
                int maximum = Math.Max(number1, number2);

                Console.WriteLine($"The maximum number is {maximum}");
                return maximum;
            }
            public bool Comparison(int number1, int number2)
            {
                bool number3 = true;
                if (number1 > number2)
                {
                    Console.WriteLine($"Is number {number1} greater than {number2}? {number3}");
                    return number3;
                }
                else
                {
                    Console.WriteLine($"Is number {number1} greater than number {number2}? {!number3}");
                    return !number3;
                }
            }
            public double Square(double number)
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine($"The square of the number {number} is equals to: {sqrt}");
                return sqrt;
            }
            public int findModulo(int number1, int number2)
            {
                int modResult = number1 % number2;
                Console.WriteLine($"The modulo of the division between number {number1} and {number2} is {modResult}");
                return modResult;
            }
        }
    }
}
