using System.Collections.ObjectModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Tasks> MyTasks { get; set; }
        
        public Tasks MyTask { get; set; }

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            BindingContext = MyTask;
        }

        private void CreateOneTask()
        {
            MyTask = new Tasks()
            {
                TaskName = "Estudiar",
                Status = "Pendiente",
                ColorText = "Blue"
            };
        }

        private void CreateAndLoadTaks()
        {
            MyTasks = new ObservableCollection<Tasks>
            {
                new Tasks
                {
                    TaskName = "Pasear al Perro",
                    Status = "Pendiente"
                },
                new Tasks
                {
                    TaskName = "Salir a Correr",
                    Status = "Pendiente"
                },
                new Tasks
                {
                    TaskName = "Entregar Tareas U",
                    Status = "Completada"
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //CreateAndLoadTaks();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Alert", "Agregado", "OK");

            var MyNewTask = new Tasks()
            {
                TaskName = "Estudiar",
                Status = "Pendiente",
                ColorText = "Red"
            };

            MyNewTask.TaskName = "Terminar la Clase";
            MyNewTask.Status = "Completado";

            BindingContext = MyNewTask;

        }
    }
}