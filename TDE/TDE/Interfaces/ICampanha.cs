using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDE.Models;

namespace TDE.Interfaces
{
    public interface ICampanha
    {
        void Insert(Campanha pCampanha);
        void Update(Campanha pCampanha);
        void Delete(int pidCampanha);
        Campanha select(int pidCampanha);
        IList<Campanha> selectAll();
    }
}
