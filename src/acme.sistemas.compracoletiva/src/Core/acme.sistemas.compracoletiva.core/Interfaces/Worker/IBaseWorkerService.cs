using Microsoft.Extensions.Hosting;

namespace acme.sistemas.compracoletiva.core.Interfaces.Worker
{
    public interface IBaseWorkerService : IHostedService, IDisposable
    {
        Task DoWork();
    }
}
