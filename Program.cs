using System.Linq.Expressions;

namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number");
                int input = int.Parse(Console.ReadLine());

                if ((input > 0) && (input <= 100))
                {
                    Console.WriteLine("Enter a series name (even, odd) ");
                    string series_name = Console.ReadLine();

                    if (series_name == "even")
                    {
                        int i = 1;
                        int even = 0;

                        while (even <= input)
                        {
                            Console.WriteLine(even.ToString() + " is an even number");
                            even = 2 * i;
                            i++;
                        }
                    }


                    else if (series_name == "odd")
                    {
                        int j = 1;
                        int odd = 1;

                        while (odd <= input)
                        {
                            Console.WriteLine(odd.ToString() + "is an odd number");
                            odd = 2 * j + 1;
                            j++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Select an option between even and odd");
                    }

                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 1 and 100");
                }

                
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again");
                Console.ReadKey(false);
            }
        }
    }
}