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

                //handle invalid case
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int i))
                {
                    responses.Add(new Response(input, "Invalid Item"));
                }

                else
                {
                    responses.Add(new Response(input, input));
                }


            }
            return Task.FromResult(responses);
        }
    }
}
