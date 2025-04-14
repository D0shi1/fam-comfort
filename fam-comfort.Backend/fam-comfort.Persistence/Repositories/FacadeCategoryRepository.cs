using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class FacadeCategoryRepository : IFacadeCategoryRepository
{
    private readonly FamComfortDbContext _context;

    public FacadeCategoryRepository(FamComfortDbContext context)
    {
        _context = context;
    }
    public async Task<List<FacadeCategory>> GetAllAsync()
    {
        return await _context.FacadesCategories.Include(f => f.Facades).ToListAsync();
    }

    public async Task<FacadeCategory> CreateAsync(FacadeCategory facadeCategory)
    {
        await _context.FacadesCategories.AddAsync(facadeCategory);
        await _context.SaveChangesAsync();
        
        return facadeCategory;
    }
}