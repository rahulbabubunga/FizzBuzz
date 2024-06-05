using FizzBuzz.Models;

namespace FizzBuzz.Service
{
    public interface IFizzBuzzService
    {
        Task<List<Response>> FetchResults(List<string> inputs);
    }
}
