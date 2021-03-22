using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] student = { "Phyllis", "Tamatha", "Loualdrah", "Lalanna", "Elijah", "Helen" };
                string[] favFood = { "seafood", "corn beef", "pork chops", "chicken", "chicken", "seafood" };
                string[] famTitle = { "Mother", "Eldest.", "Second Eldest", "Middle", "Only Son", "Baby Girl" };

                Console.WriteLine("Welcome to our Dev.Build class. Which student would you like to learn more about? (enter a number 1-7): ");
                int num = Int32.Parse(Console.ReadLine());

                    if (num <= 0 || num > 7)
                    {
                        Console.WriteLine("\nThat student does not exist. Please try again. (enter a number 1-7):");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nStudent is {student[num-1]}. What would you like to know about {student[num - 1]}? (enter 1. favorite food or 2. family title): ");
                        int option = Int32.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            Console.WriteLine($"\n{student[num - 1]} favorite food is {favFood[num - 1]}");
                        }
                        else if(option == 2)
                        {
                            Console.WriteLine($"\n{student[num - 1]} family title is {famTitle[num - 1]}");
                        }
                        else
                        {
                            Console.WriteLine($"\nThat data does not exist. Please try again (enter 1 or 2): ");
                        }

                    }


                Console.Write("\nWould you like to know about another student? (y/n): ");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    Console.Write("Thanks!\n");
                }
                else if (choice == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            while (true);
        }
    }
}
