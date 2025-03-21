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

    private void btnApagarPeriodo(object sender, EventArgs e)
    {


        DisplayAlert("Exclusão de Periodo!", $" Você tem certeza que deseja excluir este Periodo? ", "Não", "Sim");


    }
    private async void OnEditarPeriodo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///PeriodosEdit");

    }


}