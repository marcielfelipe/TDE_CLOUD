using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE.Models
{
    public class CriterioAvaliacao
    {
        public int idAvaliacao { get; set; }
        public int criatividade { get; set; }
        public int investimentoFinan { get; set; }
        public int tempoImplantacao { get; set; }
        public int reducaoCustos { get; set; }
    }
}
