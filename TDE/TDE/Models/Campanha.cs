using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE.Models
{
    public class Campanha
    {
        public int idCampanha { get; set; }
        public int idSugestao { get; set; }
        public int idAvaliacao { get; set; }
        public string responsavel { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string periodo { get; set; }
        public double valorPremio { get; set; }
    }
}
