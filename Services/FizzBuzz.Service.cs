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
        List<int> sequence = Enumerable.Range(fromInput,(toInput-fromInput)+1).ToList();
        List<string> returnedString = new List<string>();
        sequence.ForEach(x => {

            if (x % 3 == 0 && x % 5 == 0)
            {
                returnedString.Add("FizzBuzz");
            }
            else if (x % 3 == 0)
            {
                returnedString.Add("Fizz");
            }
            else if (x % 5 == 0)
            {
                returnedString.Add("Buzz");
            }
            else
            {
                returnedString.Add(x.ToString());
            }
        });
        //Console.WriteLine(returnedString);
        return String.Join(",",returnedString);
        //throw new System.NotImplementedException();
    }
}