namespace FizzBuzz.Interfaces;

interface IFizzBuzzService
{
    public string DoFizzBuzz(int input);

    public string DoFizzBuzzSeries(int fromInput,int toInput,Boolean cap);
}