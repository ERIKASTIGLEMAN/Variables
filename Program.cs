using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 0;
            var name = "Erika Stigleman";
            var date = "8/11/2020";
            Console.WriteLine(numberOfCupsOfCoffee + " " + name + " " + date);
            Console.WriteLine($"Hi {name} had {numberOfCupsOfCoffee} cups of coffee on {date}");



            Console.WriteLine("What is your name? ");

            var username = Console.ReadLine();
            Console.Write("I am glad you are with us today, ");
            Console.WriteLine(username);


            Console.WriteLine("What is your favorite even number? ");
            var firstNumberAsString = Console.ReadLine();
            // Console.WriteLine("Your favorite even number is, ");
            Console.WriteLine("What is your favorite odd number? ");
            var secondNumberAsString = Console.ReadLine();


            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            // Console.WriteLine(sum);

            Console.WriteLine($"The sum of your favorite even number and odd number is {sum}");


            var difference = secondOperand - firstOperand;
            // Console.WriteLine(difference);

            Console.WriteLine($"The difference between your favorite even number and odd number is {difference}");

            var product = secondOperand * firstOperand;
            // Console.WriteLine(product);

            Console.WriteLine($"The product of your favorite even number and odd number is {product}");

            var quotient = secondOperand / firstOperand;
            // Console.WriteLine(quotient);

            Console.WriteLine($"The quotient of your favorite even number and odd number is {quotient}");

            var remainder = secondOperand % firstOperand;
            // Console.WriteLine(remainder);

            Console.WriteLine($"The remainder of your favorite even number and odd number is {remainder}");









        }
    }
}


