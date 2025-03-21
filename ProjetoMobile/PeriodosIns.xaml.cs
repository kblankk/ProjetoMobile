namespace ProjetoMobile;

public partial class PeriodosIns : ContentPage
{
	public PeriodosIns()
	{
		InitializeComponent();
	}

    private async void OnVoltarPeriodo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Periodos");

    }
}