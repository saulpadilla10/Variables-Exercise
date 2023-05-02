using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            string dogName = "Jeffery";

            int dogAge = 10;

            char myletter = 'J';
           
            bool isDogFurry = true;

            bool isDogNice = false;

            double foodBag = 16.8;

            decimal aloNg = 9.5m;
           
           
            Console.WriteLine($"Hello there! My dog's name is {dogName}, He is {dogAge} years old.");
            Console.WriteLine($"Both our names start with {myletter}.");
            Console.WriteLine($"My dog is clean shaven! {isDogNice}. He is furry and sheds everywhere! So {isDogFurry.ToString().ToLower()}.");
            Console.WriteLine($"I buy him a {foodBag}-pound sack of dog food every month. He's been with me for {aloNg} years.");
        }
    }
}

