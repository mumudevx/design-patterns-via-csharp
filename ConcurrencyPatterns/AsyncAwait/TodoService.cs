using System.Net.Http.Json;

namespace ConcurrencyPatterns.AsyncAwait;

public interface ITodoService
{
    Task<TodoItem?> GetById(int id);
}

public class TodoService : ITodoService
{
    public async Task<TodoItem?> GetById(int id)
    {
        using var client = new HttpClient();

        try
        {
            var url = $"https://jsonplaceholder.typicode.com/todos/{id}";
            Console.WriteLine("Waiting response from API");

            var todoItem = await client.GetFromJsonAsync<TodoItem>(url);
            return todoItem;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
}