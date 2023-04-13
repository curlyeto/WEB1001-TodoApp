using System;
using System.ComponentModel.DataAnnotations;
using TodoApp.Models;

namespace TodoApp.Models
{
	public class Todo
	{
        // In model title is primary key because every title should be different.
        [Key]
        public string Title { get; set; }
        // Icompleted is bool we keep false or true data
        public bool IsCompleted { get; set; }

    }
}

