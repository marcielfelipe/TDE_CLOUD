using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDE.Models;

namespace TDE.Interfaces
{
    public interface IUsuario
    {
        void Insert(Usuario pUsuario);
        void Update(Usuario pUsuario);
        void Delete(int pidUsuario);
        Usuario select(int pidUsuario);
        IList<Usuario> selectAll();
    }
}
