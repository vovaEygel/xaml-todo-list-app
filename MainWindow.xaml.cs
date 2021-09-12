
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows;

using mytodoapp.ViewModel;

namespace mytodoapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TodoListViewModel todoItems = new TodoListViewModel();
        public static MainWindow AppWindow;
        public MainWindow()
        {
            InitializeComponent();
            todoItems.Todos = new ObservableCollection<TodoListViewModel>();
            todoItems.Todos.Add(new TodoListViewModel() { title = "First item", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", status = false });
            todoItems.Todos.Add(new TodoListViewModel() { title = "Second item", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", status = false });
            todoItems.Todos.Add(new TodoListViewModel() { title = "Third item", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", status = false });
            this.DataContext = todoItems;
            AppWindow = this;
        }
        public void newTodoWindow(object sender, RoutedEventArgs e)
        {
            add addWin = new add();
            addWin.Show();
        }
        public void addNewTodo(string title, string description)
        {
            this.todoItems.Todos.Add(new TodoListViewModel() { title = title, description= description, status = false });
            this.DataContext = todoItems;
        }
        public void deleteSelected(object sender, RoutedEventArgs e)
        {
            var list = todoItems.Todos.Where(item => item.status == true);
            foreach (TodoListViewModel item in list.ToList())
            {
                todoItems.Todos.Remove(item);
            }
        }
    }
}

