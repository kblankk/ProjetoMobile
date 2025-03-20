namespace ProjetoMobile;

public partial class Periodos : ContentPage
{
	public Periodos()
	{
		InitializeComponent();
	}

    private async void OnAdicionarPeriodo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///PeriodosIns");

    }


}