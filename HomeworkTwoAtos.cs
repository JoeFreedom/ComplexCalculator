using System;
using static System.Console;

namespace HomeworkTwoAtos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array;
            InputOutputArray(out array);
            Write("Operation menu (Max, Min, Sum, AM (for arithmetic mean, GM (for geometric mean) or 'exit' to exit ): ");
            string operationType = ReadLine();
            while (operationType != "exit")
            {
                
                switch (operationType)
                {
                    case "Max":
                        double max = array[0];
                        for (int i = 0; i < array.Length; i++)
                        {
                            max = max < array[i] ? array[i] : max; //Ternary Operation
                        }
                        WriteLine($"Max: {max} \n");
                        break;
                    case "Min":
                        double min = array[0];
                        for (int i = 0; i < array.Length; i++)
                        {
                            min = min > array[i] ? array[i] : min;  //Ternary Operation
                        }
                        WriteLine($"Min: {min} \n");
                        break;
                    case "Sum":
                        double sum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        } 
                        WriteLine($"Sum: {sum} \n");
                        break;
                    case "AM":
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
                    case "GM":
                        double sum3 = 1.0;
                        double geoMean;
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum3 *= array[i];
                        }
                        geoMean = Math.Pow(sum3, 1.0 / array.Length);
                        WriteLine($"Geometric mean: {geoMean} \n");
                        break;
                    default:
                        break;
                }
                Write("Operation menu (Max, Min, Sum, AM (for arithmetic mean, GM (for geometric mean) or 'exit' to exit ): ");
                operationType = ReadLine();
                WriteLine();
            }
            ReadKey();
        }
        public static void InputOutputArray(out double[] array)
        {
            Write("Enter the size of your intended array: ");
            int size = Convert.ToInt32(ReadLine());
            array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Write($"[{array[i]}]\t");
            }
            WriteLine("\n");
        }
        
    }
}
