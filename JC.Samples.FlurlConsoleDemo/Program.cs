using Flurl;
using Flurl.Http;
using JC.Samples.FlurlConsoleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JC.Samples.FlurlConsoleDemo
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    class Program
    {
        #region Constants

        private const string _apiBaseAddress = "https://jsonplaceholder.typicode.com";

        #endregion

        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static async Task Main(string[] args)
        {
            Console.WriteLine("Getting todos...");
            Console.WriteLine();

            // Get a list of todos from the 'JSONPlaceholder' API.
            var todos = await _apiBaseAddress
                              .AppendPathSegment("todos")
                              .SetQueryParams(new { userId = 1 })
                              .AllowAnyHttpStatus()
                              .GetJsonAsync<IEnumerable<Todo>>();

            // Display the number of todos found.
            string todoCountMessage = $"Found {todos.Count()} todos";

            Console.WriteLine(todoCountMessage);
            Console.WriteLine("".PadLeft(todoCountMessage.Length, '='));
            Console.WriteLine();

            // Output the todo titles.
            foreach (var todo in todos)
            {
                Console.WriteLine(todo.ToString());
            }

            // Inform the user that the program has completed.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");

            Console.ReadKey();
        }

        #endregion
    }
}