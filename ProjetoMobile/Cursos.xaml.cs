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
      

        DisplayAlert("Exclus�o de Curso!", $" Voc� tem certeza que deseja excluir este curso? ", "N�o", "Sim");


    }

    private async void OnEditarCurso(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///CursoEdit");

    }




}
