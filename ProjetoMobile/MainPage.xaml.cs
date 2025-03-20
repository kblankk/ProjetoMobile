namespace ProjetoMobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnBotaoClicado(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Cursos");

        }

        private async void OnDisciplinas(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Disciplinas");

        }

        private async void OnPeriodos(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Periodos");

        }





    }

}
