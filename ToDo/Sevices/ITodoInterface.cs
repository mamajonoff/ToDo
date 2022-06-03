using ToDo.Models;

namespace ToDo.Sevices
{
    public interface ITodoInterface
    {
        List<TodoModel> GetAll();
        TodoModel GetById(int id);
        TodoModel AddTodo(string title);
        void Done(int id);
        void NotDone(int id);
        void DeleteTodo(int id);
    }
}
