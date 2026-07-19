namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Step 1 
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            // Step 2
            for (int j = 1; j <= 20; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
            }
        }
        
        // Step 3
        int k = 5;
        while (k >= 1)
        {
            Console.WriteLine(k);
            k--;
        }
        
        // Step 4
        int m = 10;
        while (m <= 1000)
        {
            Console.WriteLine(m);
            m += 10;
        }
        
        // Step 5
        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        
        // Step 6
        string[] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        foreach (string d in day)
        {
            Console.WriteLine(d);
        }
        
        // Step 7
        string[] bookTitles = {"To Kill a Mockingbird", "Dune", "Harry Potter"};
        string[] authors = {"Harper Lee", "Frank Herbert", "J.K. Rowling"};
        for (int b = 0; b < bookTitles.Length; b++)
        {
            Console.WriteLine(bookTitles[b] + " by " + authors[b]);
        }
        
        // Step 8
        int[] temperatures = {10, 20, 30, 40, 50};
        Array.Sort(temperatures);
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Highest: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest: " + temperatures[0]);
        
        // Step 9
        int[] numbers = {5, 4, 3, 2, 1};
        Array.Reverse(numbers);
        for (int n = 0; n < numbers.Length; n++)
        {
            Console.WriteLine(numbers[n]);
        }
    }
}