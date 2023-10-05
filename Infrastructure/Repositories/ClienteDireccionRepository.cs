using Infrastructure.Data;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repositories;
public class ClienteDireccionRepository : GenericRepository<ClienteDireccion>,IClienteDireccion
{
    private readonly AnimalsContext _context;

    public ClienteDireccionRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}