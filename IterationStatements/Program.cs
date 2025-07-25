namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; --i)
                Console.WriteLine(i.ToString());
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static void PrintEveryThirdNumber()
        {
            for(int i = 3; i <= 999; i++)
                if (i % 3 == 0)
                    Console.WriteLine(i.ToString());
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        static bool IsPositive(int number)
        {
            return number > 0 ? true : false;
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        static bool CanVote(int age)
        {
            return age >= 18 ? true : false;
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        static bool IsInRange(int number)
        {
            return number < 10 && number > -10 ? true : false;
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
                Console.WriteLine((i * number).ToString());
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to see values 1000 to -1000 printed.");
            Console.ReadLine();

            PrintNumbers();

            Console.WriteLine("Press enter to see every third value from 3 to 999 printed.");
            Console.ReadLine();

            PrintEveryThirdNumber();

            int a = 0;
            a = GetIntInput(a, "Please submit two numbers to check if they are equal.");

            int b = 0;
            b = GetIntInput(b, "Please submit your second number.");

            string result;
            result = $"{a} and {b} are " + (AreNumbersEqual(a, b) ? "equal." : "not equal");
            Console.WriteLine(result);

            a = GetIntInput(a, "Please submit a number to check if it even.");
            result = $"{a} is " + (IsEven(a) ? "even" : "odd");
            Console.WriteLine(result);

            a = GetIntInput(a, "Please submit a number to check if it positive.");
            result = $"{a} is " + (IsPositive(a) ? "positive" : "negative");
            Console.WriteLine(result);

            a = GetIntInput(a, "Please submit your age to check if you can vote.");
            result = (CanVote(a) ? "You can" : "You can't") + $" vote at the age of {a}.";
            Console.WriteLine(result);

            a = GetIntInput(a,
                "Please submit a number to check if it is in range of -10 to 10.");

            result = $"{a} is " + (IsInRange(a) ? "in range." : "not in range.");
            Console.WriteLine(result);

            a = GetIntInput(a,
                "Please submit a number to see it's multiplication table from * 1 to * 12.");

            DisplayMultiplicationTable(a);
        }

        static int GetIntInput(int val, string text)
        {
            Console.WriteLine(text);

            while (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Please input an integer.");
            }

            return val;
        }
    }
}
