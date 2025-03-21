namespace ProjetoMobile;

public partial class CursoEdit : ContentPage
{
	public CursoEdit()
	{
		InitializeComponent();
	}


    private async void OnVoltarCurso(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Cursos");

    }
}