using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.DataService
{
    public interface IRestService
    {
        Task<List<Todo>> GetAllTodosAsync();

        Task AddTodoAsync(Todo item);

        Task UpdateTodo(Todo item);

        Task DeleteTodoAsync(int id);
    }
}
