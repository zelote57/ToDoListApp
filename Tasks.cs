using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoListApp
{
    public class Tasks : INotifyPropertyChanged
    {
        private string taskName;
        private string status;
        private string colorText;

        public string TaskName
        {
            get => taskName; set
            {
                taskName = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => status; set
            {
                status = value;
                OnPropertyChanged();
            }
        }
        public string ColorText
        {
            get => colorText; set
            {
                colorText = value;
                OnPropertyChanged();
            }
        }

        public Tasks()
        {            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this,
                 new PropertyChangedEventArgs(propName));
        }
    }
}
