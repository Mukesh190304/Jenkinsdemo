using System;

namespace CalculatorApp

{

    public class Calculator

    {

        public int add(int a, int b)

        {

            return a + b;

        }

        public int product(int a, int b)

        {

            return a * b;

        }

    }

    public class Program

    {

        public static void Main(string[] args)

        {

            Calculator c = new Calculator();

            int add = c.add(1, 2);

            Console.WriteLine("Addition: " + add);

            int product = c.product(1, 2);

            Console.WriteLine("Product: " + product);

        }

    }

}

