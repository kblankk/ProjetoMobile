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
    private void btnApagaDisciplina(object sender, EventArgs e)
    {


        DisplayAlert("Exclus�o de Disciplina!", $" Voc� tem certeza que deseja excluir esta disciplina? ", "N�o", "Sim");


    }
    private async void OnEditarDisciplina(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///DisciplinaEdit");

    }


}