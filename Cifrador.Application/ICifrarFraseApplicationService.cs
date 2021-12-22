using Cifrador.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cifrador.Application
{
    public interface ICifrarFraseApplicationService/*<TEntity, TId> where TEntity: Entity<TId>, new()
        where TId: IComparable, IComparable<TId>*/
    {
        public string CifrarFrase(string frase);
    }
}
