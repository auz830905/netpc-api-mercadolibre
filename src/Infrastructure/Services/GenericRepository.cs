using HttpParamsUtility;
using MercadoLibre.SDK;
using NETPC.ApiMercadoLibre.Core.Interfaces;
using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Infrastructure.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MeliApiService _repository;

        public GenericRepository(MeliApiService repository) {
            _repository = repository; 
        }

        public async Task<T> Get(string url, Dictionary<string, string>? param = null)
        {
            HttpParams? p = null;

            if (param != null)
            {
                p = new();

                foreach (KeyValuePair<string, string> entry in param)
                {
                    p.Add(entry.Key, entry.Value);
                }
            }

            var response = await _repository.GetAsync(url, p);

            var json = await response.Content.ReadAsStringAsync();

            var entity = JsonConvert.DeserializeObject<T>(json!);

            return entity!;
        }

        public async Task<IList<T>> GetAll(string url, Dictionary<string, string>? param = null)
        {
            HttpParams? p = null;

            if (param != null)
            {
                p = new();

                foreach (KeyValuePair<string, string> entry in param)
                {
                    p.Add(entry.Key, entry.Value);
                }
            }
            
            var response = await _repository.GetAsync(url, p);
                            
            var json = await response.Content.ReadAsStringAsync();

            var entity = JsonConvert.DeserializeObject<IList<T>>(json!);

            return entity!;            
        }        
    }
}
