
using CadastroEventos.Models;

namespace CadastroEventos.Views;
public partial class ContratacaoEvento : ContentPage
{

	App PropriedadesApp;

	public ContratacaoEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_evento.ItemsSource = PropriedadesApp.lista_eventos;

        dtpck_inicio.MinimumDate = DateTime.Now.AddDays(7);
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 2, DateTime.Now.Month, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(1);

    }

    private async void Button_Clicked_pag_resumo_contratacao(object sender, EventArgs e)
    {
        try
        {
            ResumoContratacao h = new ResumoContratacao
            {
                
            };

            await Navigation.PushAsync(new ResumoContratacao());


        } catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "ok");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_incio = elemento.Date;

        dtpck_termino.MinimumDate = data_selecionada_incio.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada_incio.AddMonths(1);

    }
}