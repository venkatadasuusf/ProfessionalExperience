/*
 Author: Venkata Dasu
 Date: 9/10/2019
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many years of experience do you have in professional programming ...");
            
            try
            {
                string input = Console.ReadLine();
                
                int experience = int.Parse(input);
                
                if (experience <= 2)
                {
                    switch (experience)
                    {
                        case 0:
                            Console.WriteLine("Need lots of practice");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Looks like you have a little experience");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Wow! You've been doing this for a little while");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        
                    } // end of switch              
                }
                else if (experience > 2)
                {
                    Console.WriteLine("You are an expert!");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                           
                }
                else 
                {
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);

                }

            } // end of try
            catch
            {
                Console.WriteLine("Please use a integer data type for your experience details next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
