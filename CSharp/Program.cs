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
            ParseFromStringsWithTryParse();
            Console.ReadLine();
        }
        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("→ Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine($"Value of b: {b}");
            }
            string value = "94.518";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine($"Value of b: {d}");
            }
            else
            {
                Console.WriteLine($"Failed to convert the input ({value}) to a double");
            }
            
        }
        static void ParseFromString()
        {
            Console.WriteLine("→ Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine($"Value of b: {b}");
            double d = double.Parse("98,345");
            Console.WriteLine($"Value of d: {d}");
            int i = int.Parse("17");
            Console.WriteLine($"Value of i: {i}");
            char c = char.Parse("w");
            Console.WriteLine($"Value of c: {c}");
        }
        static void CharFunctionality()
        {
            Console.WriteLine("→ CharFunctionality");
            char myChar = 'a';
            string myString = "Hello everyone";
            Console.WriteLine($"char.IsLetter('a') = {char.IsLetter(myChar)}");
            Console.WriteLine($"char.IsDigit('a') = {char.IsDigit(myChar)}");
            Console.WriteLine($"char.IsWhiteSpace(\"Hello everyone\", 5) = {char.IsWhiteSpace(myString, 5)}");
            Console.WriteLine($"char.IsWhiteSpace(\"Hello everyone\", 7) = {char.IsWhiteSpace(myString, 7)}");
            Console.WriteLine($"char.IsPunctuation('!') = {char.IsPunctuation('!')}");
        }
        static void BooleanFunctionality()
        {
            Console.WriteLine("→ BooleanFunctionality");
            Console.WriteLine($"bool.TrueString = {bool.TrueString}");
            Console.WriteLine($"bool.FalseString = {bool.FalseString}");
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("→ Data type Functionality:");
            Console.WriteLine($"Max of int: {int.MaxValue:N}");
            Console.WriteLine($"Min of int: {int.MinValue:N}");
            Console.WriteLine($"Max of double: {double.MaxValue}");
            Console.WriteLine($"Min of double: {double.MinValue}");
            Console.WriteLine($"double.Epsilon: {double.Epsilon}");
            Console.WriteLine($"double.PositiveInfinity: {double.PositiveInfinity}");
            Console.WriteLine($"double.NegativeInfinity: {double.NegativeInfinity}");
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine($"System.Object Functionality: ");
            Console.WriteLine($"12.GetHashCode() = {12.GetHashCode()}");
            Console.WriteLine($"12.Equals(23) = {12.Equals(23)}");
            Console.WriteLine($"12.ToString() = {12.ToString()}");
            Console.WriteLine($"12.GetType() = {12.GetType()}");
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
