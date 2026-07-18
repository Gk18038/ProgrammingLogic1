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
            for (int j = 1; j <= 20 ; j++)
            {
                Console.WriteLine(j);
                if (j % 2 == 0)
                {
                    Console.WriteLine("Even");
                    // Step 3
                    int k = 5;
                    while (k >= 1) 
                    {
                        Console.WriteLine(k);
                        k--;
                        // Step 4
                    int m = 10;
                    while (m <= 1000)
                    {
                        Console.WriteLine(m);
                        m += 10;
                        // Step 5
                        string [] seasons = {"Spring", "Summer", "Fall", "Winter"};
                        foreach (string season in seasons)
                        {
                            Console.WriteLine(season);
                            // Step 6
                            String [] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
                            if (day.Length >= 7)
                            {
                                Console.WriteLine("Invalid day!");
                                // Step 7
                                
                            }
                            {
                                }
                            }
                        }
                    }
                    }
                }
            }
        }
    }


