using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class CitaRepository : GenericRepository<Cita>, ICita
{
    private readonly AnimalsContext _context;

    public CitaRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}