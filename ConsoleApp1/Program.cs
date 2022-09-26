using System;
using System.Security.AccessControl;

public class Program
{
    public static void Main()
    {
        bool trigger = false;

        while (!trigger)
        {
            Console.WriteLine("Please input the Radius of a circle. \n");


            string input = Console.ReadLine();
            double radius = double.Parse(input);

            Console.WriteLine("\nRadius: " + radius);
            Console.WriteLine();

            double area = Math.PI * (radius * radius);

            Console.WriteLine("\nArea: " + area);

            Console.WriteLine("\nWould you like to measure another circle? Input 'yes' or 'y' to continue, or any other key to exit.\n");

            string reply = Console.ReadLine();

            if (reply == "y" || reply == "yes" || reply == "Yes")
            {
                trigger = false;
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nGoodbye!");
                trigger = true;
            }
        }
            
    }
}