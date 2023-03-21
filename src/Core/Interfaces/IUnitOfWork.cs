using NETPC.ApiMercadoLibre.Core.Entities;

namespace NETPC.ApiMercadoLibre.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Base> Base { get; }
        IGenericRepository<Site> Site { get; }
        IGenericRepository<Domain> Domain { get; }
        IGenericRepository<Category> Category { get; }
    }
}
