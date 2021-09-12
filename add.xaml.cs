using System;
using System.Windows;

using System.Windows.Input;


namespace mytodoapp
{
    /// <summary>
    /// Interaction logic for add.xaml
    /// </summary>
    public partial class add : Window
    {
       public string todoTitle { get; set; }
        public string todoDescription { get; set; }
        public add()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        public void addTodo(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(this.todoDescription)!=true && String.IsNullOrEmpty(this.todoTitle) != true)
            {
                mytodoapp.MainWindow.AppWindow.addNewTodo(this.todoTitle, this.todoDescription);
                this.todoTitle = "";
                this.todoDescription = "";
                CloseCommandHandler(null, null);
            }
        }
    }
}
