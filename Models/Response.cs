namespace FizzBuzz.Models
{
    public class Response
    {
        public string Input { get; set; }
        public string Result { get; set; }

        public Response(string input, string result)
        {
            Input = input;
            Result = result;
        }

    }
}
