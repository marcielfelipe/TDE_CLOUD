using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
    }
}
