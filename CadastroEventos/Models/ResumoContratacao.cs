namespace CadastroEventos.Models
{
    public class ResumoContratacao
    {

        public Evento evento_selecionado { get; set; }
        public int qtde_adultos { get; set; }
        public int qtde_crianças { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataTermino { get; set; }
        public int temDecoracao { get; set; }
        public int temBuffet { get; set; }

        public int tempoEvento
        {
            get => dataTermino.Subtract(dataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                //valores adulto
                double valor_adulto = qtde_adultos * evento_selecionado.valorAdulto;
                double valor_buffet_adulto = qtde_adultos * evento_selecionado.buffetAdulto;
                //valores criança
                double valor_crianca = qtde_crianças * evento_selecionado.valorCrianca;
                double valor_buffet_crianca = qtde_crianças * evento_selecionado.buffetCrianca;
                //valores adultos + valores crianças
                double total_evento = (valor_adulto + valor_crianca) * tempoEvento;
                //buffet adulto + buffet criança
                double total_buffet = (valor_buffet_adulto + valor_buffet_crianca) * tempoEvento;
                //valor decoração
                double total_decoracao = evento_selecionado.decoracao * tempoEvento;
                //total geral
                double total_geral = (total_evento + total_buffet + total_decoracao);

                return total_geral;

            }
        }
    }
}
