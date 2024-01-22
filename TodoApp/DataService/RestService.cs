using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.DataService
{

   
    public class RestService: IRestService
    {
        private readonly IRestService _service;
        public RestService(IRestService service)
        {

            _service = service;

        }

        public Task AddTodoAsync(Todo item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Todo>> GetAllTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodo(Todo item)
        {
            throw new NotImplementedException();
        }
    }
}
