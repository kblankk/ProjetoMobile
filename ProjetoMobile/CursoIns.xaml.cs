namespace ProjetoMobile;

public partial class CursoIns : ContentPage
{
	public CursoIns()
	{
		InitializeComponent();
	}
    private async void OnVoltarCurso(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Cursos");

    }
}