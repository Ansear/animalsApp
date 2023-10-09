using Infrastructure.Data;
using Core.Interfaces;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork,IDisposable
{
    private readonly AnimalsContext _context;
    private ICita _citas;
    private ICiudad _ciudades;
    private ICliente _clientes;
    private IClienteDireccion _clienteDireccion;
    private IClienteTelefono _clienteTelefono;
    private IDepartamento _departamentos;
    private IMascota _mascotas;
    private IPais _paises;
    private IRaza _razas;
    private IServicio _servicios;
    public UnitOfWork(AnimalsContext context)
    {
        _context = context;
    }

    public ICita Citas
    {
        get 
        {
            _citas ??= new CitaRepository(_context); //Metodo abreviado segun la documentacion https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/null-coalescing-operator, seccion ejemplos cuarto punto
            return _citas;
        }
    }

    public ICiudad Ciudades
    {
        get
        {
            _ciudades ??= new CiudadRepository(_context);
            return _ciudades;
        }
    }

    public ICliente Clientes
    {
        get
        {
            _clientes ??= new ClienteRepository(_context);
            return _clientes;
        }
    }

    public IClienteDireccion ClienteDirecciones
    {
        get 
        {
            _clienteDireccion ??= new ClienteDireccionRepository(_context);
            return _clienteDireccion;
        }
    }

    public IClienteTelefono ClienteTelefonos
    {
        get 
        {
            _clienteTelefono ??= new ClienteTelefonoRepository(_context);
            return _clienteTelefono;
        }
    }

    public IDepartamento Departamentos
    {
        get 
        {
            _departamentos ??= new DepartamentoRepository(_context);
            return _departamentos;
        }
    }

    public IMascota Mascotas
    {
        get 
        {
            _mascotas ??= new MascotaRepository(_context);
            return _mascotas;
        }
    }

    public IPais Paises
    {
        get 
        {
            _paises ??= new PaisRepository(_context);
            return _paises;
        }
    }

    public IRaza Razas
    {
        get 
        {
            _razas ??= new RazaRepository(_context);
            return _razas;
        }
    }

    public IServicio Servicio
    {
        get 
        {
            _servicios ??= new ServicioRepository(_context);
            return _servicios;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}