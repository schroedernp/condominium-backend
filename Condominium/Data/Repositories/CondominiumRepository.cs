using Application.Domain.Entities;
using Application.DTO;
using Application.Interfaces;

namespace Data.Repositories
{
    public class CondominiumRepository : ICondominiumRepository
    {
        public async Task<IEnumerable<Condominium>> GetAll()
        {
            return new List<Condominium>
            {
              new Condominium
              {
                  Id = Guid.NewGuid(),
                  Name = "SolNascente"
              },
               new Condominium
              {
                  Id = Guid.NewGuid(),
                  Name = "Danubio"
              },
            };
        }
    }
}
