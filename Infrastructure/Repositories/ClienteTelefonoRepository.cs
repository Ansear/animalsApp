using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class ClienteTelefonoRepository : GenericRepository<ClienteTelefono>, IClienteTelefono
{
    private readonly AnimalsContext _context;

    public ClienteTelefonoRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}