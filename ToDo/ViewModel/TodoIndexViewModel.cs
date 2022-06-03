using ToDo.Models;

namespace ToDo.ViewModel
{
    public class TodoIndexViewModel
    {
        public List<TodoModel> TodoList { get; set; }
        public string NewTodoTitle { get; set; }
        public TodoModel Todo { get; set; }
    }
}
