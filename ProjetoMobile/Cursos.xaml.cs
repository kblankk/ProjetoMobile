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

    private void btnApagarCurso(object sender, EventArgs e)
    {
      

        DisplayAlert("Exclusão de Curso!", $" Você tem certeza que deseja excluir este curso? ", "Não", "Sim");


    }

    private async void OnEditarCurso(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///CursoEdit");

    }




}
