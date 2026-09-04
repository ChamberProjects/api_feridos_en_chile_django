using System.Collections.Generic;
using System.Threading.Tasks;
using FeriadosChileNet5.Models;

namespace FeriadosChileNet5.Services
{
    public interface IFeriadosService
    {
        Task<List<Feriado>> ObtenerFeriadosAsync();
    }
}
