using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDE.Models;

namespace TDE.Interfaces
{
    public interface IEmpresa
    {
        void Insert(Empresa pEmpresa);
        void Update(Empresa pEmpresa);
        void Delete(int pidEmpresa);
        Empresa select(int pidEmpresa);
        IList<Empresa> selectAll();
    }
}
