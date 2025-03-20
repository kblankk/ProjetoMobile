namespace ProjetoMobile;

public partial class Disciplinas : ContentPage
{
	public Disciplinas()
	{
		InitializeComponent();
	}

    private async void OnAdicionarDiscplina(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///DisciplinaIns");

    }

}