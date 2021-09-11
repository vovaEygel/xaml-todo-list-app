using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using mytodoapp.ViewModel;

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
        public void addTodo(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(this.todoDescription)!=true)
            {
                mytodoapp.MainWindow.AppWindow.addNewTodo(this.todoTitle, this.todoDescription);
                this.todoTitle = "";
                this.todoDescription = "";
            }
        }
        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
