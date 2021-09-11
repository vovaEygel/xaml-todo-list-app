using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
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

            todoItems.Todos.Add(new TodoListViewModel() { title = "todo", description = "description", status=false });
            todoItems.Todos.Add(new TodoListViewModel() { title = "todo1", description = "description1", status = true });
            todoItems.Todos.Add(new TodoListViewModel() { title = "todo2", description = "description2", status = false });
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

