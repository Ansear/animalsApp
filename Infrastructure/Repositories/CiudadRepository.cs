using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
{
    private readonly AnimalsContext _context;

    public CiudadRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Ciudad>> GetAllAsync()
    {
        return await _context.Ciudades.Include(p => p.Departamentos).ThenInclude(c => c.Ciudades).ToListAsync();
    }
}