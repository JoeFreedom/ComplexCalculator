using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeworkThreeAtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Choose type of regime (Interactive or Batch): ");
            string regime = ReadLine();   // ????
            
            if (args[0] == "-batch")
            {
                if (args.Length != 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        WriteLine(args[i]);
                    }
                }
                Write("Enter first number: ");
                int num1 = Convert.ToInt32(ReadLine());
                Write("Enter second number: ");
                int num2 = Convert.ToInt32(ReadLine());
                switch (args[1])
                {
                    case "-add":
                        WriteLine($"Sum equals = {Convert.ToInt32(args[2].Substring(1)) + Convert.ToInt32(args[3].Substring(1)) + Convert.ToInt32(args[4].Substring(1))}");
                        break;
                    case "-subtract":
                        
                    default:
                        break;
                }
            }
            else if(regime == "Interactive")
            {
                MenuFunction();
            }
           

        }
        public static int ValidatingSizeInput()
        {
            int number;
            bool IsTryParse = false;
            do
            {
                Write("Enter the size of your array: ");
                string temp = ReadLine();
                IsTryParse = int.TryParse(temp, out number); // validating int input

                if (!IsTryParse)
                {
                    WriteLine("Enter only numbers");
                }
            }
            while (!IsTryParse);
            return number;
        }
        public static void InputOneDimensionalArray(out double[] array)
        {
            int size = ValidatingSizeInput();
            array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(In.ReadLine());   // TO-DO validating array input.
            }
            for (int i = 0; i < array.Length; i++)
            {
                Write($"[{array[i]}]\t");
            }
            WriteLine("\n");
        }
        public enum EnumMenuFunction { Max = 1, Min = 2, Sum = 3, AM = 4, GM = 5, Transpose = 6, ArrayMultiplication = 7, Exit = 8 }
        public static void MenuFunction()
        {
            double[] array;
            InputOneDimensionalArray(out array);

            EnumMenuFunction enumMenu;
            WriteLine("***What would you like to find from an array?***"); 
            Write("Max, Min, Sum, AM (for arithmetic mean, GM (for geometric mean), Transpose or 'exit' to exit ): ");
            string temp = ReadLine();
            bool IsInMenu = Enum.TryParse(temp, out enumMenu);
            if (IsInMenu)
            {
                do
                {
                   
                    switch (enumMenu)
                    {
                        case EnumMenuFunction.Max:
                            double max = array[0];
                            for (int i = 0; i < array.Length; i++)
                            {
                                max = max < array[i] ? array[i] : max;
                            }
                            WriteLine($"Max: {max} \n");
                            break;
                        case EnumMenuFunction.Min:
                            double min = array[0];
                            for (int i = 0; i < array.Length; i++)
                            {
                                min = min > array[i] ? array[i] : min;
                            }
                            WriteLine($"Min: {min} \n");
                            break;
                        case EnumMenuFunction.Sum:
                            double sum = 0;
                            foreach (var item in array)
                            {
                                sum += item;
                            }
                            WriteLine($"Sum: {sum} \n");
                            break;
                        case EnumMenuFunction.AM:
                            double mean;
                            double sum2 = 0;
                            int count = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                sum2 += array[i];
                                count++;
                            }
                            mean = sum2 / count;
                            WriteLine($"Arithmetic mean: {mean} \n");
                            break;
                        case EnumMenuFunction.GM:
                            double sum3 = 1.0;
                            double geoMean;
                            for (int i = 0; i < array.Length; i++)
                            {
                                sum3 *= array[i];
                            }
                            geoMean = Math.Pow(sum3, 1.0 / array.Length);
                            WriteLine($"Geometric mean: {geoMean} \n");
                            break;
                        case EnumMenuFunction.Transpose:
                            // TO-DO
                        default:
                            break;
                    }
                    
                    Write("Operation menu (Max, Min, Sum, AM (for arithmetic mean, GM (for geometric mean), Transpose or 'exit' to exit ): ");
                    temp = ReadLine();
                    IsInMenu = Enum.TryParse(temp, out enumMenu);
                }
                while (enumMenu != EnumMenuFunction.Exit);
                
            }
            else
            {
                WriteLine("Nah, try again");
            }
        }
    }
}
