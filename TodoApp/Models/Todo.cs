using System;
using System.ComponentModel.DataAnnotations;
using TodoApp.Models;

namespace TodoApp.Models
{
	public class Todo
	{
        [Key]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

  

        public List<Todo> getTodoList()
        {
            List<Todo> todos = new List<Todo>();
            todos.Add(new Todo { Title = "Play basketball", IsCompleted = true });
            todos.Add(new Todo { Title = "Shopping", IsCompleted = false });
            todos.Add(new Todo { Title = "Assignment", IsCompleted = true });
            todos.Add(new Todo { Title = "Workout", IsCompleted = false });
            todos.Add(new Todo { Title = "Make food", IsCompleted = false });
            todos.Add(new Todo { Title = "Cleaning", IsCompleted = true });
            
            return todos;
        }


        public List<Todo> getIsnotCompletedList()
        {
            
            List<Todo> isNotCompletedList = new List<Todo>();
            foreach (Todo todo in new Todo().getTodoList())
            {
                if (todo.IsCompleted == false)
                {
                    isNotCompletedList.Add(todo);
                }
            }
            return isNotCompletedList;
        }

    }
}

