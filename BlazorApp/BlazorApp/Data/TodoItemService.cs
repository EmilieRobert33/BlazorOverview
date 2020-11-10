using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TodoItemService
    {
        public IList<TodoItem> todos = new List<TodoItem>();
        public string newTodo;

        public void AddTodo()
        {
            if (!String.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo, IsDone = false });
                newTodo = string.Empty;
            }
        }
    }
}
