using FizzBuzz.Models;

namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public Task<List<Response>> FetchResults(List<string> inputs)
        {
            var responses = new List<Response>();
            foreach (var input in inputs)
            {
                responses.Add(FetchResult(input));

            }
            return Task.FromResult(responses);
        }

        public Response FetchResult(string input)
        {
            //handle invalid case upfront
            int i = 0;
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out i))
            {
                return new Response(input, new List<string>() { "Invalid Item" });
            }

            else
            {
                bool divisibleBy3, divisibleBy5;
                divisibleBy3 = divisibleBy5 = false;

                if (i % 3 == 0)
                    divisibleBy3 = true;
                if (i % 5 == 0)
                    divisibleBy5 = true;

                if (divisibleBy3 && divisibleBy5)
                {
                    return new Response(input, new List<string>() { "FizzBuzz" });
                }
                else if (divisibleBy3)
                {
                    return new Response(input, new List<string>() { "Fizz" });
                }
                else if (divisibleBy5)
                {
                    return new Response(input, new List<string>() { "Buzz" });
                }
                else
                {
                    return new Response(input, new List<string>() { $"Divided {input} by 3", $"Divided {input} by 5" });
                }
            }
        }
    }
}
