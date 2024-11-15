namespace CadastroEventos.Views;

public partial class ResumoContratacao : ContentPage
{
	public ResumoContratacao()
	{
		InitializeComponent();
	}

    public void VoltarContratacao(object sender, EventArgs e)
    {

		App.Current.MainPage = new ContratacaoEvento();

    }

    private void FinalizarCotacao(object sender, EventArgs e)
    {
        App.Current.MainPage = new ContratacaoFinalizada();
    }
}