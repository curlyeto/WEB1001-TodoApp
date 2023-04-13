using System;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
	public class TodoDbContext:DbContext
	{
        // Set model to our database
        public DbSet<Todo> Todo { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
         : base(options)
        { }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add data to table with Todo model.
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Play basketball", IsCompleted=true }) ;
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Shopping", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Assignment", IsCompleted = true });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Workout", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Make food", IsCompleted = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Title = "Cleaning", IsCompleted = true });

        }

    }
}

