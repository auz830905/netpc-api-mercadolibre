using MercadoLibre.SDK;
using NETPC.ApiMercadoLibre.Core.Entities;
using NETPC.ApiMercadoLibre.Core.Interfaces;

namespace NETPC.ApiMercadoLibre.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeliApiService _repository;
        private IGenericRepository<Site>? _site;
        private IGenericRepository<Domain>? _domain;
        private IGenericRepository<Base>? _base;
        private IGenericRepository<Category>? _category;

        public UnitOfWork(MeliApiService repository) 
        {
            _repository = repository;
        }

        public IGenericRepository<Site> Site => _site ??= new GenericRepository<Site>(_repository);

        public IGenericRepository<Domain> Domain => _domain ??= new GenericRepository<Domain>(_repository);

        public IGenericRepository<Base> Base => _base ??= new GenericRepository<Base>(_repository);

        public IGenericRepository<Category> Category => _category ??= new GenericRepository<Category>(_repository);

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
