namespace ProjetoMobile;

public partial class DisciplinaIns : ContentPage
{
	public DisciplinaIns()
	{
		InitializeComponent();
	}

    private async void OninserirDisciplina(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Disciplinas");

    }
}