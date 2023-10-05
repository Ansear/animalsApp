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
            if(_citas == null)
            {
                _citas = new CitaRepository(_context);
            }
            return _citas;
        }
    }

    public ICiudad Ciudades
    {
        get
        {
            if(_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context);
            }
            return _ciudades;
        }
    }

    public ICliente Clientes
    {
        get
        {
            if(_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }

    public IClienteDireccion ClienteDirecciones
    {
        get 
        {
            if(_clienteDireccion == null)
            {
                _clienteDireccion = new ClienteDireccionRepository(_context);
            }
            return _clienteDireccion;
        }
    }

    public IClienteTelefono ClienteTelefonos
    {
        get 
        {
            if(_clienteTelefono == null)
            {
                _clienteTelefono = new ClienteTelefonoRepository(_context);
            }
            return _clienteTelefono;
        }
    }

    public IDepartamento Departamentos
    {
        get 
        {
            if(_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }

    public IMascota Mascotas
    {
        get 
        {
            if(_mascotas == null)
            {
                _mascotas = new MascotaRepository(_context);
            }
            return _mascotas;
        }
    }

    public IPais Paises
    {
        get 
        {
            if(_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }

    public IRaza Razas
    {
        get 
        {
            if(_razas == null)
            {
                _razas = new RazaRepository(_context);
            }
            return _razas;
        }
    }

    public IServicio Servicio
    {
        get 
        {
            if(_servicios == null)
            {
                _servicios = new ServicioRepository(_context);
            }
            return _servicios;
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}