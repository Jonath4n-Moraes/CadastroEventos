namespace CadastroEventos.Models
{
    public class ResumoContratacao
    {

        public Evento evento_selecionado { get; set; }
        public int Qtde_adultos { get; set; }
        public int Qtde_crianças { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int TemDecoracao { get; set; }
        public int TemBuffet { get; set; }

        public int tempoEvento
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                //valores adulto
                double valor_adulto = Qtde_adultos * evento_selecionado.valorAdulto;
                double valor_buffet_adulto = Qtde_adultos * evento_selecionado.buffetAdulto;
                //valores criança
                double valor_crianca = Qtde_crianças * evento_selecionado.valorCrianca;
                double valor_buffet_crianca = Qtde_crianças * evento_selecionado.buffetCrianca;
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
