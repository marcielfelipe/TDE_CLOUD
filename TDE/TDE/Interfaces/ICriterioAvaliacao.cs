using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDE.Models;

namespace TDE.Interfaces
{
    public interface ICriterioAvaliacao
    {
        void Insert(CriterioAvaliacao pCriterioAvaliacao);
        void Update(CriterioAvaliacao pCriterioAvaliacao);
        void Delete(int pidCriterioAvaliacao);
        CriterioAvaliacao select(int pidCriterioAvaliacao);
        IList<CriterioAvaliacao> selectAll();
    }
}
