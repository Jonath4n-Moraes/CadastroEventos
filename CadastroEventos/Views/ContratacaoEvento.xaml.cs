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

        pck_local_evento.ItemsSource = PropriedadesApp.lista_local;

        dtpck_inicio.MinimumDate = DateTime.Now.AddDays(7);
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 2, DateTime.Now.Month, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(1);

    }

    private async void Button_Clicked_pag_resumo_contratacao(object sender, EventArgs e)
    {

        try
        {
            if (pck_evento.SelectedItem != null &&  pck_local_evento.SelectedItem != null && !string.IsNullOrWhiteSpace(qtde_adultos.Text))
            {

                Resumo h = new Resumo
                {
                    evento_selecionado = (Evento)pck_evento.SelectedItem,
                    Qtde_adultos = Convert.ToInt32(qtde_adultos.Text),
                    Qtde_criancas = Convert.ToInt32(qtde_criancas.Text),
                    DataInicio = dtpck_inicio.Date,
                    DataTermino = dtpck_termino.Date,
                    TemBuffet = chk_buffet.IsChecked ? 1 : 0,
                    TemDecoracao = chk_decoracao.IsChecked ? 1 : 0,
                    EspacoSelecionado = (Espacos)pck_local_evento.SelectedItem,
                    NomeEvento = nome_evento.Text,

                };


                await Navigation.PushAsync(new ResumoContratacao()
                {
                    BindingContext = h,
                });

            }
            else
            {
                await DisplayAlert("Atenção", "Selecione tipo evento, local de evento e número de adultos", "OK");
            }          
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