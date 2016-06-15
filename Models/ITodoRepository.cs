using Microsoft.EntityFrameworkCore;


namespace SimpTodoAngular2.Models
{
    public interface ITodoRepository
    {
        bool Add(TodoItem item);
        DbSet<TodoItem> GetAll();
        bool UpdateTodo(TodoItem item);
        bool DeleteTodo(string id);
        bool MarkComplete(TodoItem item);
        TodoItem Get(int id);
    }
}
