using Application.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICondominiumRepository
    {
        Task<IEnumerable<Condominium>> GetAll();
    }
}
