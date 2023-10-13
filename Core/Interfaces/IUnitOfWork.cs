using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPaisRepository Paises {get ;}
        ICiudadRepository Ciudades {get;}
        IDepartamentoRepository Departamentos {get ;}
        IClienteRepository Clientes {get;}
        IMascotaRepository Mascotas {get;}
        IServicioRepository Servicios {get;}
        IClienteTelRepository ClientesTel {get;}
        IClienteDirRepository ClientesDirs {get;}
        ICitaRepository Citas {get;}
        Task<int> SaveAsync();
    }
}