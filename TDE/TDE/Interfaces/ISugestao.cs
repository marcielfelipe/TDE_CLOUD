using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDE.Models;

namespace TDE.Interfaces
{
    public interface ISugestao
    {
        void Insert(Sugestao pSugestao);
        void Update(Sugestao pSugestao);
        void Delete(int pidSugestao);
        Sugestao select(int pidSugestao);
        IList<Sugestao> selectAll();
    }
}
