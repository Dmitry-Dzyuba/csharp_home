using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{
    class ThisWillNeverComplile
    {
        //private var myInt = 10;
        // public var MyMethod(var x, var y);
        
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ExecuteIfElseUsingConditionalOperator();

            Console.ReadLine();
        }
        static void ExecuteIfElseUsingConditionalOperator()
        {
            string stringData = default;
            Console.WriteLine(stringData?.Length > 0? "String is greater than 0 symbols":"String is empty");
        }
        static void IfElseExample()
        {
            string stringData = "My Textual data";
            /*   if (stringData.Length) так нельзя
            {

            }
            else
            {

            }*/
            //так можно
            if (stringData.Length > 0)
            {
                Console.WriteLine("String is greater than 0 symbols");
            }
        }
        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower()!="yes");
        }
        static void WhileLoopExample()
        {
            string userIsDone = "";
            while (userIsDone.ToLower()!="yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
        static void ForEachLoopExample()
        {
            string[] carTypes = { "BMW", "Ford", "Mercedez", "Mazda" };
            foreach (string str in carTypes)
            {
                Console.WriteLine(str);
            }
            int[] numbers = { 1, 5, 4, 12, 65, 2 };
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"number is {i}");
            }
        }
        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //LINQ query
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var item in subset)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"subset is a: {subset.GetType().Name}");
            Console.WriteLine($"subset is defined in: {subset.GetType().Namespace}");
        }
        static void ImplicitTypingIsStrongTyping()
        {
            var s = "This variable can only hold string data!";
            s = "It's fine...";
            string upper = s.ToUpper();
            Console.WriteLine(s);
            Console.WriteLine(upper);
            // Ошибка! Присваивание типов, отличных от string, карается исключением
            //s = 44;
        }
        static int ThisWillNeverBeCompiled()
        {
            // Ошибка! Должно быть присвоено значение!
            //var myData;
            // Ошибка! Значение должно присваиваться в самом объявлении!
            // var mylnt;
            // mylnt = 0;
            //Ошибка! Нельзя присваивать Null в качестве начального значения
            //var myObj = null;
            var neverCom = new ThisWillNeverComplile();
            neverCom = null;
            var myInt = 0;
            var anotherInt = myInt;
            string myString = "Wake up!";
            var myData = myString;
            var retVal = 9;
            return retVal;
        }
        static void DeclarelmplicitVars()
        {
            var myInt = 5;
            var myBool = true;
            var myString = "Je m'appelle Dmitri";
            Console.WriteLine($"myInt has type: {myInt} = {myInt.GetType()}");
            Console.WriteLine($"myBool has type: {myBool} = {myBool.GetType()}");
            Console.WriteLine($"myString has type: {myString} = {myString.GetType()}");
        }
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
           // try
            {
                //checked
                {
                    byte sum = ((byte)Add(b1, b2));
                    Console.WriteLine($"sum is {sum}");
                }

            }
            //catch (OverflowException ex)
            {

                //Console.WriteLine(ex.Message);
            }
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void StringInterpolation()
        {
            int age = 4;
            string name = "Soren";
            /*Использование синтаксиса с фигурными скобками
             * и использованием метода .Format()
             */
            string greeting = string.Format("Hello {0}, you are {1} years old.", name, age);
            string greeting2 = $"Hello {name}, you are {age} years old.";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            greeting = string.Format("Hello {0}, you are {1} years old.", name.ToUpper(), age);
            greeting2 = $"Hello {name.ToUpper()}, you are {age} years old.";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);

        }
        static void StringBuilderMethod()
        {
            Console.WriteLine("→ Using String Builder. 128");
            StringBuilder stringBuilder = new StringBuilder("***Fantastic Games***");
            stringBuilder.Append("\n");
            stringBuilder.AppendLine("Half Life");
            stringBuilder.AppendLine("Morrowwind");
            stringBuilder.AppendLine("Deus Ex" + " 2");
            stringBuilder.AppendLine("System Shock");
            Console.WriteLine(stringBuilder);
            stringBuilder.Replace("2", "Invisible War");
            Console.WriteLine(stringBuilder);
            Console.WriteLine($"stringBuilder has {stringBuilder.Length} chars");




        }
        static void StringsAreImmutable()
        {
            string s1 = "This is my string.";
            Console.WriteLine($"s1 = {s1}");
            string upperString = s1.ToUpper();
            Console.WriteLine($"upperString is {upperString}");
            Console.WriteLine($"s1 = {s1}");
        }
        static void StringEqualitySpecifyingCompareRules()
        {
            string s1 = "Préférer!";
            string s2 = s1.ToUpper();
            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
            Console.WriteLine();
            // Проверить результаты изменения стандартных правил сравнения.
            Console.WriteLine($"Default rules: s1 = {s1}, s2 = {s2}," +
                $"s1.Equals(s2): {s1.Equals(s2)}");
            Console.WriteLine($"Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {s1.Equals(s2, StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase)}");
            Console.WriteLine($"Default rules: s1 = {s1}, s2 = {s2}," +
                $"s1.IndexOf(\"E\"): {s1.IndexOf("É")}");
            Console.WriteLine($"Ignore case: " +
                $"s1.IndexOf(\"É\", StringComparison.OrdinalIgnoreCase): {s1.IndexOf("É", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Ignore case, Invariant Culture: " +
                   $"s1.IndexOf(\"É\", StringComparison.InvariantCultureIgnoreCase): {s1.IndexOf("É", StringComparison.InvariantCultureIgnoreCase)}");
        }
        static void BinaryLiterals()
        {
            Console.WriteLine("→ BinaryLiterals:");
            Console.WriteLine($"16: {0b0001_0000}");
            Console.WriteLine($"32: {0b0010_0000}");
            Console.WriteLine($"56: {0b0011_1000}");
        }
        static void StringEquality()
        {
            Console.WriteLine("→ String equality. 124");
            string s1 = "Hello";
            string s2 = "Yo";
            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
            Console.WriteLine($"s1 == s2: {s1 == s2}");
            Console.WriteLine($"s1 == Hello: {s1 == "Hello"}");
            Console.WriteLine($"s1 == HELLO: {s1 == "Hello".ToUpper()}");
            Console.WriteLine($"s1 == hello: {s1 == "Hello".ToLower()}");
            Console.WriteLine($"s1 with NonRegister {s1.Equals("Hello", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"\"Yo\".Equals(s2): {"Yo".Equals(s2)}");
        }
        static void VerbatimStringDefinition()
        {
            Console.WriteLine(@"C:\Myapp\bin\Debug");
            string myLongString =
                @"This is a very
            very
              very
                long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets """);
        }
        static void EscapeChars()
        {
            Console.WriteLine("→ Escape sequencies");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello world\"\a");
            Console.WriteLine("C:\\myApp\\bin\\debug");
            Console.WriteLine("s\r");
            Console.WriteLine("All finished.\n\n\n\n");

        }
        static void CodeBlogCycles()
        {
            List<int> list = new List<int>();
            int cnt = 15;
            while (list.Count < cnt)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    list.Add(value);
                }
                else
                {
                    Console.WriteLine($"Строка не является числом. Введите ещё раз");
                }
            }
            int sum = 0;
            for (int j = 0; j < list.Count; j++)
            {
                sum += list[j];
            }
            Console.WriteLine($"Sum of a list is {sum}");
            int substract = list[list.Count - 1];
            int i = list.Count - 1;
            while (i > 0)
            {
                substract -= list[i--];
            }
            Console.WriteLine($"Substraction is {substract}");
            long mul = 1;
            i = 0;
            do
            {
                mul *= list[i];
            } while (i++ < list.Count - 1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void CodeBlogIf()
        {

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int.TryParse(Console.ReadLine(), out int c);
            if (a > b && a > c)
            {
                Console.WriteLine($"{a}>{b} and {a}>{c}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b}>{a} and {b}>{c}");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"{c}>{a} and {c}>{b}");
            }
            int.TryParse(Console.ReadLine(), out int even);
            if (even % 2 == 0)
            {
                Console.WriteLine($"{even} is even");
            }
            else
            {
                Console.WriteLine($"{even} is odd");
            }
            int.TryParse(Console.ReadLine(), out int fast);
            string result = (fast < 100) ? "да" : "нет";
            Console.WriteLine(result);

        }
        static void StringConcatenation()
        {
            Console.WriteLine("→ String concatenation: 122");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            string s4 = string.Concat(s1, s2, s3);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality: 121");
            string firstName = "Freddy";
            Console.WriteLine($"Value of firstName: {firstName}");
            Console.WriteLine($"firstName has {firstName.Length} characters");
            Console.WriteLine($"firstName in UpperCase: {firstName.ToUpper()}");
            Console.WriteLine($"firstName in LowerCase: {firstName.ToLower()}");
            Console.WriteLine($"firstName contains the letter y: " +
                $"{firstName.Contains("y")}");
            Console.WriteLine($"firstName after replace: {firstName.Replace("dy", "")}");
        }
        static void DigitSeparators()
        {
            Console.WriteLine("=> Use digit separators: (120)");
            Console.WriteLine("Integer:");
            Console.WriteLine(123_456);
            Console.WriteLine("Long:");
            Console.WriteLine(123_456_789L);
            float f = 123_456.7254544f;
            Console.WriteLine($"Float: {f}");
            Console.WriteLine(123_456.7254F);
            Console.WriteLine("Double:");
            Console.WriteLine(123_464.44561);
            Console.WriteLine("Decimal:");
            Console.WriteLine(123_456.12M);
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("→ Dates and Times:");
            DateTime dateTime = new DateTime(2021, 03, 28);
            Console.WriteLine($"The day of {dateTime.ToShortDateString()} is {dateTime.DayOfWeek}");
            Console.WriteLine($"Daylight savings: {dateTime.IsDaylightSavingTime()}");
            TimeSpan ts = new TimeSpan(4, 30, 15);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(1, 49, 35)));
            DateTime dateTime1 = new DateTime(2004, 05, 02);


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
