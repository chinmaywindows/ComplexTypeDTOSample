using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SampleApp.Core.Context;

namespace SampleApp.Data.Repositories
{
    public class AdventureWorksRepository : IAdventureWorksRepository, IDisposable
    {
        private bool disposedValue;
        private readonly AdventureWorks2017Context _context;
        private readonly ILogger _logger;

        public AdventureWorksRepository(AdventureWorks2017Context adventureWorks2017Context, ILogger<AdventureWorksRepository> logger)
        {
            _logger = logger;
            _context = adventureWorks2017Context ?? throw new ArgumentNullException(nameof(adventureWorks2017Context));
        }



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~AdventureWorksRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
