namespace CadastroEventos.Views;

public partial class ResumoContratacao : ContentPage
{
	public ResumoContratacao()
	{
		InitializeComponent();
	}

    private async void VoltarContratacao(object sender, EventArgs e)
    {

		await Navigation.PopAsync();

    }

    private void FinalizarCotacao(object sender, EventArgs e)
    {
        App.Current.MainPage = new ContratacaoFinalizada();
    }
}