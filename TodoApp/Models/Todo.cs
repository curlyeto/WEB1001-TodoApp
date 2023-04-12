using System;
using System.ComponentModel.DataAnnotations;
namespace TodoApp.Models
{
	public class Todo
	{
        [Key]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}

