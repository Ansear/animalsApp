using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly AnimalsContext _context;

    public PaisRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}