using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class MascotaRepository : GenericRepository<Mascota>, IMascota
{
    private readonly AnimalsContext _context;

    public MascotaRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}