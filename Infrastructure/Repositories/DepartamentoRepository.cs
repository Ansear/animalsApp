using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly AnimalsContext _context;

    public DepartamentoRepository(AnimalsContext context) : base(context)
    {
        _context = context;
    }
}