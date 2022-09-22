using FizzBuzz.Interfaces;

namespace FizzBuzz.Services;

class FizzBuzzService : IFizzBuzzService
{
    public string DoFizzBuzz(int input)
    {
        string returnedString = string.Empty;
        if (input % 3 == 0)
        {
            returnedString = returnedString + "Fizz";
        }
        if (input % 5 == 0)
        {
            returnedString = returnedString + "Buzz";
        }
        if(input % 5 != 0 && input %3 !=0){
            returnedString = returnedString + input;
        }
        //Console.WriteLine(returnedString);
        return returnedString;
        //throw new System.NotImplementedException();
    }
    public string DoFizzBuzzSeries(int fromInput,int toInput)
    {
        List<int> sequence = Enumerable.Range(fromInput,toInput-fromInput).ToList();
        string returnedString = string.Empty;
        sequence.ForEach(x => {

            if (x % 3 == 0)
            {
                returnedString = returnedString + "Fizz";
            }
            if (x % 5 == 0)
            {
                returnedString = returnedString + "Buzz";
            }
            if (x % 5 != 0 && x % 3 != 0)
            {
                returnedString = returnedString + x;
            }
        });
        //Console.WriteLine(returnedString);
        return returnedString;
        //throw new System.NotImplementedException();
    }
}