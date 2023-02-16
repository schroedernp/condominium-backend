using Application.DTO;
using Application.Interfaces;
using Application.Services.Interfaces;
using System.Linq;

namespace Application.Services
{
    public class CondominiumService : ICondominiumService
    {
        private readonly ICondominiumRepository condominiumRepository;
        public CondominiumService(ICondominiumRepository condominiumRepository)
        {
            this.condominiumRepository = condominiumRepository;
        }
        //Recebe Condominium e devolve um CondominiumDTO
        public async Task<IEnumerable<CondominiumDTO>> GetAll()
        {
            var condominiums = await this.condominiumRepository.GetAll();
            var condominiumsMapped = condominiums.Select(x => new CondominiumDTO { Id = x.Id , Name = x.Name});

            return condominiumsMapped;
        }
    }
}
