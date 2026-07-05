internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /* [George Koussa] [IT-1050 - Lab 1] */
        // Step 2
        Console.WriteLine("George Koussa IT-1050");
        // Step 3
        int favoriteNumber = 11;
        string favoriteLanguage = "Python";
        double programsWrittenBefore = 0;
        bool hasProgrammingExperience = false;

        Console.WriteLine(favoriteNumber);
        Console.WriteLine("My favorite programming language is: " + favoriteLanguage);
        Console.WriteLine("Programs written before this: " + programsWrittenBefore);
        Console.WriteLine("Programming experience: " + hasProgrammingExperience);
        // Step 4 
        const string schoolName = "School name is TRI-C";
        Console.WriteLine(schoolName);
        // Step 5
        double myDouble = 9.78;
        int myInt = (int)myDouble;
        int myInt2 = (int)myDouble;
        bool myBool = true;
        Console.WriteLine(Convert.ToString(myBool));
        // Step 6
        Console.WriteLine("Write your name here: ");
        Console.WriteLine("Enter your age here: ");
        Console.ReadLine();
        int userAge = Convert.ToInt32(Console.ReadLine());
        // Step 7
        int num1 = 5;
        int num2 = 10;

        int additionResult = num1 + 10;
        int subtractionResult = num1 - 2;
        int multiplicationResult = num1 * 3;
        int divisionResult = num1 / 2;
        int modulusResult = num1 % 2;

        Console.WriteLine("Addition result (num1 + 10): " + additionResult);
        Console.WriteLine("Subtraction result (num1 - 2): " + subtractionResult);
        Console.WriteLine("Multiplication result (num1 * 3): " + multiplicationResult);
        Console.WriteLine("Division result (num1 / 2): " + divisionResult);
        Console.WriteLine("Modulus result (num1 % 2): " + modulusResult);
        int additionResult2 = num2 + 10;
        int subtractionResult2 = num2 - 2;
        int multiplicationResult2 = num2 * 3;
        int divisionResult2 = num2 / 2;
        int modulusResult2 = num2 % 2;

        Console.WriteLine("Addition result (num2 + 10): " + additionResult2);
        Console.WriteLine("Subtraction result (num2 - 2): " + subtractionResult2);
        Console.WriteLine("Multiplication result (num2 * 3): " + multiplicationResult2);
        Console.WriteLine("Division result (num2 / 2): " + divisionResult2);
        Console.WriteLine("Modulus result (num2 % 2): " + modulusResult2);
        // Step 8
        float floatNum1 = 1.123456789f;
        double doubleNum2 = 1.123456789d;
        Console.WriteLine("Float number: " + floatNum1);
        Console.WriteLine("Double number: " + doubleNum2);
        // Step 9
        int declared = 10;
        Console.WriteLine("Initial value: " + declared);

        declared++;
        Console.WriteLine("After increment (++): " + declared);

        declared--;
        Console.WriteLine("After decrement (--): " + declared);
    }
}