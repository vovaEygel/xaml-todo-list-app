using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace mytodoapp.ViewModel
{
    public class TodoListViewModel 
    {
        public ObservableCollection<TodoListViewModel> Todos { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Boolean status { get; set; }
    }
}
