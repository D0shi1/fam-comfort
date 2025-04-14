using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IFacadeRepository
{
    Task<List<Facade>> GetAllAsync();
    Task<Facade> Create(Facade facade);
}