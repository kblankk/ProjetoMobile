namespace ProjetoMobile;

public partial class PeriodosEdit : ContentPage
{
	public PeriodosEdit()
	{
		InitializeComponent();
	}
    private async void OnVoltarPeriodos(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Periodos");

    }
}