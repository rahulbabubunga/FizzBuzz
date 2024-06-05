namespace FizzBuzz.Models
{
    public class Response
    {
        public string Input { get; set; }
        public List<string> Results { get; set; }

        public Response(string input, List<string> results)
        {
            Input = input;
            Results = results;
        }

    }
}
