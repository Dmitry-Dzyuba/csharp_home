using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DisplayMessage();


            Console.ReadLine();

        }
        static void DisplayMessage()
        {
            string userMessage = string.Format($"100000 in hex is {100_000:X}");
            System.Windows.MessageBox.Show(userMessage);
        }
        static void FormatNumericalData()
        {
            Console.WriteLine($"The value 9999 in various formats:");
            Console.WriteLine($"c format: {9999:c}");
            Console.WriteLine($"d6 format: {9999:d6}");
            Console.WriteLine($"e format {9999:e}");
            Console.WriteLine($"E format {9999:E}");
            Console.WriteLine($"f3 format {9999:f3}");
            Console.WriteLine($"n format {9999:n}");
            Console.WriteLine($"g format {9999:g}");
            Console.WriteLine($"X format {9999:X}");
            Console.WriteLine($"x format {9999:x}");
        }
    }
}
