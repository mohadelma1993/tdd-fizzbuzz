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
        var inputCli = Console.ReadLine();
        int number;
        
        if (!String.IsNullOrEmpty(inputCli) && Int32.TryParse(inputCli, out number))
        {
            var result = this.fizzBuzzService.DoFizzBuzz(number);
            Console.WriteLine(result);
            Environment.Exit(0);
        }
        else {
            Console.WriteLine("You need to provide the input number and the input number only");
            return;
        }
            

/*        if (!int.TryParse(args[0], out var input))
            throw new ArgumentException("You must provide an integer number as input");
*/
        Environment.Exit(0);
    }
}