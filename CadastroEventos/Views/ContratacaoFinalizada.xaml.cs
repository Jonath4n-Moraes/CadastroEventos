namespace CadastroEventos.Views;

public partial class ContratacaoFinalizada : ContentPage
{
	public ContratacaoFinalizada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new ContratacaoEvento();
    }
}