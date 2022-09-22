using FizzBuzz.Interfaces;
using System;

namespace FizzBuzz;

class FizzBuzzHost : IFizzBuzzHost
{
    private readonly IFizzBuzzService fizzBuzzService;

    public FizzBuzzHost(IFizzBuzzService fizzBuzzService)
    {
        this.fizzBuzzService = fizzBuzzService;
    }

    public void Run(string[] args)
    {
        try
        {
            /*var inputCli = Console.ReadLine();
            int number;

            //task 1 (single integer)
            if (!String.IsNullOrEmpty(inputCli) && Int32.TryParse(inputCli, out number))
            {
                var result = this.fizzBuzzService.DoFizzBuzz(number);
                Console.WriteLine(result);
                
            }
            else
            {
                Console.WriteLine("You need to provide the input number and the input number only");
                return;
            }
            Environment.Exit(0);
            //task 1 (single integer)*/

            //task 2 (fizzbuzz series)
            int from, to;
            string? inputCli = string.Empty;
            Console.Write("from: ");
            inputCli = Console.ReadLine();
            bool fromParsed = Int32.TryParse(inputCli, out from);

            Console.Write("to: ");
            inputCli = Console.ReadLine();
            bool toParsed = Int32.TryParse(inputCli, out to);

            if (fromParsed && toParsed)
            {
                var result = this.fizzBuzzService.DoFizzBuzzSeries(from,to);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You need to provide the input number and the input number only");
                return;
            }
            Environment.Exit(0);
            //task 2 (fizzbuzz series)
        }
        catch (Exception e) //catch exception for invalid input, such as a letter
        {
            Console.WriteLine(e.Message);
        }
         Environment.Exit(0);
    }
}