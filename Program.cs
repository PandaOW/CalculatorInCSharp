using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" _____                                _______                ______    ");
            Console.WriteLine("|    |   /|  |\\    | | \\      /|     |            /| |      |        ");
            Console.WriteLine("|    |  / |  | \\   | |  \\    / |     |           / | |      |        ");
            Console.WriteLine("|____| /__|  |  \\  | |   \\  /__|     |          /__| |      |        ");
            Console.WriteLine("|     /   |  |   \\ | |   / /   |     |         /   | |      |         ");
            Console.WriteLine("|    /    |  |    \\| |__/ /    |     |_______ /    | |_____ |______   ");
            

            Console.WriteLine("\n \n \n \n ***Press Enter to begin***");

            Console.ReadLine();

            Console.WriteLine("1.) Addition");
            Console.WriteLine("2.) Subtraction");
            Console.WriteLine("3.) Multiplication");
            Console.WriteLine("4.) Division");
            Console.WriteLine("5.) Exponent (num1^num2)");

            Console.Write(" \n \n Please choose your operator with the corresponding number: ");
            double oper = Convert.ToDouble(Console.ReadLine()); //choosing operator

            Console.Write("Enter the first digit: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); //waits for input

            Console.Write("Enter the second digit: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); //waits for input

            //my results variables
            double addition = num1 + num2;
            double multi = num1 * num2;
            double sub = num1 - num2;
            double div = num1 / num2;
            double exp = Math.Pow(num1, num2); //eponents



           

            


            // Addition Operator
            if (oper == 1)
            {

                Console.WriteLine(num1 + " + " + num2 + " = " + addition);
                Console.WriteLine(" \n Press Enter Twice To Close Program");

            }

            // Subtraction Operator
            else if (oper == 2)
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + sub);
                Console.WriteLine(" \n Press Enter Twice To Close Program");
            }

            // Multiplication Operator
            else if (oper == 3)
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + multi);
                Console.WriteLine(" \n Press Enter Twice To Close Program");

            }

            // Division Operator
            else if (oper == 4)
            {

                Console.WriteLine(num1 + " / " + num2 + " = " + div);
                Console.WriteLine(" \n Press Enter Twice To Close Program");

            }

            // Exponents
            else if (oper == 5)
            {
                Console.WriteLine(num1 + "^" + num2 + " = " + exp);
                Console.WriteLine(" \n Press Enter Twice To Close Program");
            }

            else
            {
                Console.WriteLine("Input not recognized, please start again");
                Console.WriteLine(" \n Press Enter Twice To Close Program");
            }


            Console.ReadLine();

        }
    }
}
