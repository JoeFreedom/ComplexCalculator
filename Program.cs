using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HomeworkOneAtos
{
    class Program
    {
       static void Main(string[] args)
        {
            string operationType;
            double numOne, numTwo;
            do
            {
                do
                {
                    Write("Enter Intended Operation by writing (add, subtract, divide, multiply, remainder, squareroot, nth-Root or 'exit' to exit ): ");
                    operationType = ReadLine();
                }
                while (operationType != "add" && operationType != "subtract" && operationType != "divide" && operationType != "multiply" && operationType != "remainder" 
                && operationType != "squareroot" && operationType != "exit" && operationType != "nth-Root");
                switch (operationType)
                {
                    case "add":
                        numOne = ValidatingInput();
                        numTwo = ValidatingInput();
                        WriteLine($"The result when added is: {numOne + numTwo} \n");
                        break;
                    case "subtract":
                        numOne = ValidatingInput();
                        numTwo = ValidatingInput();
                        WriteLine($"The result when subtracted is: {numOne - numTwo} \n");
                        break;
                    case "divide":
                        numOne = ValidatingInput();
                        numTwo = ValidatingInput();
                        if (numTwo != 0)
                        {
                            WriteLine($"The result when divided is: {numOne / numTwo} \n");
                        }
                        else if (numTwo == 0)
                        {
                            WriteLine($"Division impossible by {numTwo} \n");
                        }
                        break;
                    case "multiply":
                        numOne = ValidatingInput();
                        numTwo = ValidatingInput();
                        WriteLine($"The result when multiplied is: {numOne * numTwo} \n");
                        break;
                    case "remainder":
                        numOne = ValidatingInput();
                        numTwo = ValidatingInput();
                        WriteLine($"The remainder of {numOne} divided by {numTwo} is: {numOne % numTwo} \n");
                        break;
                    case "squareroot":
                        numOne = ValidatingInput();
                        WriteLine($"The square root of {numOne} is: {Sqrt(numOne)}");
                        break;
                    case "nth-Root": // TO-DO nth root // having problem with the mathematical logic
                        double number = ValidatingInput();
                        double root = ValidatingInput();
                        double temp = Math.Pow(number, (1.0 / root) );
                        //double nthRoot = Math.Pow(temp, root);
                        WriteLine($"The {root}nth root of {number} is: {temp} \n");
                        break;
                    default:
                        WriteLine("Goodbye, since you're leaving \n");
                        break;
                }                        
            }
            while (operationType != "exit");    
            ReadKey();
        }
       public static double ValidatingInput()
        {
            double number;
            bool IsTryParse = false;
            do
            {
                Write("Enter number: ");
                string temp = ReadLine();
                IsTryParse = double.TryParse(temp, out number); // validating double input

                if (!IsTryParse)
                {
                    WriteLine("Enter only numbers");
                }
            }
            while (!IsTryParse);
            return number;
        }
    }
}
