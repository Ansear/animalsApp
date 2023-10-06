using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
{
    private readonly AnimalsContext _context;

    public CiudadRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}