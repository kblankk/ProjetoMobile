namespace ProjetoMobile;

public partial class Cursos : ContentPage
{
	public Cursos()
	{
		InitializeComponent();
	}
    private async void OnAdicionarCurso(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///CursoIns");

    }

    private async void OnVoltarMenu(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");

    }




}
