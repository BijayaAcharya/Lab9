using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> names = new List<string> { "David", "Bob", "Leon", "Adam", "Mat", "Lavid", "Chris", "Leoen", "Ada", "Patric" };
            List<string> favFoods = new List<string> { "Sandwich", "Taco", "Mac n Cheese", "pasta", "spagetti", "Sandwich", "Taco", "Mac n Cheese", "pasta", "spagetti" };
            List<string> hometowns = new List<string> { "Detroit", "Canton", "Novi", "Southfield", "Troy", "Detroit", "Canton", "Novi", "Southfield", "Troy" };
            List<int> numbers = new List<int> { 5, 7, 8, 9, 11, 23, 6, 2, 3, 10 };

            while (true)
            {
                Console.WriteLine(" Welcome to C# Class! Would you like to know about a students or add a new student: print 'add' or 'know'?");
                string input = Console.ReadLine().ToLower();

                
                if (input == "add")
                {
                    Console.WriteLine(" Enter the student's name.");
                    string name = Console.ReadLine().ToLower();
                    if (!string.IsNullOrWhiteSpace(name))//&& Regex.IsMatch(name, @"^[a-zA-Z]$"))
                    {
                        names.Add(name);
                    }

                    Console.WriteLine(" Enter the favorite food.");
                    string food = Console.ReadLine().ToLower();
                    if (!string.IsNullOrWhiteSpace(food))
                    {
                        favFoods.Add(food);
                    }

                    Console.WriteLine(" Enter the hometown.");
                    string hometown = Console.ReadLine().ToLower();
                    if (!string.IsNullOrWhiteSpace(hometown))
                    {
                        hometowns.Add(hometown);
                    }

                    Console.WriteLine(" Enter the lucky number.");
                    string num = Console.ReadLine();
                    if (Regex.IsMatch(num, @"^\d{2}$"))
                    {
                        numbers.Add(Convert.ToInt32(num));
                    }
                }

                if (input == "know")
                {
                    Console.WriteLine(" Please enter a number between 1-10");
                    string selction = Console.ReadLine();

                    Console.WriteLine($"This is {names[Convert.ToInt32(selction)]}! What would you like to know about {names[Convert.ToInt32(selction)]}?");
                    string info = "";

                    Console.WriteLine($"Would you like to know about {names[Convert.ToInt32(selction)]}'s hometown, food or number? Please print the word!");
                    info = Console.ReadLine().ToLower();


                    if (Regex.IsMatch(info, @"^hometown$"))
                    {
                        Console.WriteLine($"This is {names[Convert.ToInt32(selction)]}! He is from {hometowns[Convert.ToInt32(selction)]}");
                    }

                    else if (Regex.IsMatch(info, @"^food$"))
                    {
                        Console.WriteLine($"This is {names[Convert.ToInt32(selction)]}! His favfood is {favFoods[Convert.ToInt32(selction)]}");

                    }

                    else if (Regex.IsMatch(info, @"number$")) //validating input
                    {

                        Console.WriteLine($"This is {names[Convert.ToInt32(selction)]}! His lucky number is: {numbers[Convert.ToInt32(selction)]}");

                    }

                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }


                    Console.WriteLine("Do you want to continue?, 'y/n'"); // asking user input

                    string asnwer = Console.ReadLine().ToLower(); // reading from the console and converting user input into lower case

                    if (asnwer == "n")
                    {
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }

            }
        }
    }
}

        
    

