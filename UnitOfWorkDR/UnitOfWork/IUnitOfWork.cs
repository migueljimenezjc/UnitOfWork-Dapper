using RepositoriesER;
using RepositoriesER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDR.API.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICuestionario CuestionarioRepository { get; }
        IMoneda MonedaRepository { get; }
    }
}
