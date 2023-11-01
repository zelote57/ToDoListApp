using System.Collections.ObjectModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        //public Tasks MyTask { get; set; }

        Tasks MiTarea = new Tasks();

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            BindingContext = MiTarea;
        }

        private void CreateOneTask()
        {
            MiTarea = new Tasks()
            {
                TaskName = "Comprar Pan",
                Status = "Pendiente",
                ColorText = "Blue"
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //CreateAndLoadTaks();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            MiTarea.TaskName = "Otra Tarea";
            MiTarea.Status = "Completa";
            MiTarea.ColorText = "Red";
        }
    }
}