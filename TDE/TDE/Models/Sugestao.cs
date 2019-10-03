using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE.Models
{
    public class Sugestao
    {
        public int idSugestao { get; set; }
        public int idUsuario { get; set; }
        public string descricao { get; set; }
        public double custoEnvolvido { get; set; }
    }
}
