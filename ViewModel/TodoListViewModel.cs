using System;
using System.Collections.ObjectModel;


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
