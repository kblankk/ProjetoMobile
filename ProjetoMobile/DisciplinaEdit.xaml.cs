namespace ProjetoMobile;

public partial class DisciplinaEdit : ContentPage
{
	public DisciplinaEdit()
	{
		InitializeComponent();
	}

    private async void OnVoltarDisciplina(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Disciplinas");

    }
}