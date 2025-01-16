using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if(hour > 0 && hour < 12)
                {
                Console.WriteLine("It's morning.");
                }
            else if(hour >= 12 && hour < 18)
                {
                Console.WriteLine("It's afternoon.");
                }
            else
                {
                Console.WriteLine("It's evening.");
                }

            bool isGoldCustomer = true;

            //float price;
            //if(isGoldCustomer)
            //price = 19.95f;
            //else
            //price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                Console.WriteLine("It's autumn and a beautiful season.");
                break;
                
                case Season.Summer:
                Console.WriteLine("It's perfect to go to beach.");
                break;

                default:
                Console.WriteLine("I dont understand that season!");
                break;

            }

            // This is the start of the for loops demo

            for ( var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for( var i = 10; i >= 1; i--)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // This is the start of the foreach loops demo

            var name = "John Smith";
            
            //for(var i = 0; i < name.Length; i++)
            //{
              //  Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers  = new int[] { 1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            // This is the start of the while loops demo


            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; 
                }

                break;
            }
        }
    }
}