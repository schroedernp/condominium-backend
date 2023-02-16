using Application.DTO;

namespace Application.Services.Interfaces
{
    public interface ICondominiumService
    {
        Task<IEnumerable<CondominiumDTO>> GetAll();
    }
}
