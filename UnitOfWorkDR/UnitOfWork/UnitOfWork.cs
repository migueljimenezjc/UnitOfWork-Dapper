﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoriesER;
using RepositoriesER.Interfaces;

namespace UnitOfWorkDR.API.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue = false;

        public UnitOfWork(
            ICuestionario cuestionarioRepository,
            IMoneda monedaRepository
            )
        {
            CuestionarioRepository = cuestionarioRepository;
            MonedaRepository = monedaRepository;
        }

        public ICuestionario CuestionarioRepository { get; }
        public IMoneda MonedaRepository { get; }

        public void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
