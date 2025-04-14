using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class FacadeRepository : IFacadeRepository
{
    private readonly FamComfortDbContext _famComfortDbContext;

    public FacadeRepository(FamComfortDbContext famComfortDbContext)
    {
        _famComfortDbContext = famComfortDbContext;
    }
    public async Task<List<Facade>> GetAllAsync()
    {
        return await _famComfortDbContext.Facades.ToListAsync();
    }

    public async Task<Facade> Create(Facade facade)
    {
        return facade;
    }
}