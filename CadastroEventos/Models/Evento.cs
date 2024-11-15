using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos.Models
{
    public class Evento
    {

        public string descricao {  get; set; }
        public double valorAdulto { get; set; }
        public double valorCrianca { get; set; }
        public double buffetAdulto { get; set; }
        public double buffetCrianca { get; set; }
        public double decoracao { get; set; }

    }
}
