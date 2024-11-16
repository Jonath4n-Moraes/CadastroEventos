namespace CadastroEventos.Models
{
    public class Resumo
    {

        public Evento evento_selecionado { get; set; }
        public Espacos EspacoSelecionado { get; set; }
        public int Qtde_adultos { get; set; }
        public int Qtde_criancas { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int TemDecoracao { get; set; }
        public int TemBuffet { get; set; }
        public string NomeEvento { get; set; }
        public string LocalEvento { get; set; }

        public int tempoEvento
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorLocacao
        {
            get
            {
                double valor_locacao = EspacoSelecionado.valorLocacao * tempoEvento;

                return valor_locacao;
            }
        }

        public double ValorBuffet
        {
            get
            {
                if (TemBuffet == 1)
                {
                    double valor_buffet = ((Qtde_adultos * evento_selecionado.buffetAdulto) + (Qtde_criancas * evento_selecionado.buffetCrianca)) * tempoEvento;

                    return valor_buffet;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double ValorDecoracao
        {
            get
            {
                if (TemDecoracao == 1)
                {
                    double valor_decoracao = evento_selecionado.decoracao * tempoEvento;

                    return valor_decoracao;
                } 
                else
                {
                    return 0;
                }
            }
        }

        public double ValorTotal
        {
            get
            {
                double valor_total = ValorLocacao + ValorBuffet + ValorDecoracao;

                return valor_total;
            }
        }

        public double CustoParticipante
        {
            get
            {
                double custo_participante = ValorTotal / (Qtde_adultos + Qtde_criancas);

                return custo_participante;
            }
        }
    }
}
