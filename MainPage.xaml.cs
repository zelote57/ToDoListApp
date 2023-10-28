using System.Collections.ObjectModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Tasks> MyTasks { get; set; }
        //public string MyTitle { get; set; } = "Lista de Tareas";

        public MainPage()
        {
            InitializeComponent();            
            //BindingContext = this;            
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


            //source
            var task = new Tasks()
            {
                TaskName = "Estudiar",
                Status = "Pendiente"
            };

            //binding
            Binding bindingTarea = new Binding();

            bindingTarea.Source = task;
            bindingTarea.Path = "TaskName";

            Binding bindingEstatus = new Binding();

            bindingEstatus.Source = task;
            bindingEstatus.Path = "Status";

            //target
            Tarea.SetBinding(Label.TextProperty, bindingTarea);

            Estatus.SetBinding(Label.TextProperty, bindingEstatus);

        }
    }
}