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


        DisplayAlert("Exclus�o de Periodo!", $" Voc� tem certeza que deseja excluir este Periodo? ", "N�o", "Sim");


    }
    private async void OnEditarPeriodo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///PeriodosEdit");

    }


}