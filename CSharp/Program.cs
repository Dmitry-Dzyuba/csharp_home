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
            NewingDataTypes();
            Console.ReadLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using \"new\" to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine($"b = {b}, i = {i}, d = {d}, dt = {dt}");
        }
        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations");
            int myInt = default;
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = default;
            string myString = "This is my character data";
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine($"Your data: {myInt}, {myString}, {b1}, {b2}, {b3}, {b4}");


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
