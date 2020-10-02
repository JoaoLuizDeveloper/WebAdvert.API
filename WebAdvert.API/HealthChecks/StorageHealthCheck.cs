using AdvertApi.Models.Services;
using Microsoft.Extensions.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace WebAdvert.API.HealthChecks
{
    public class StorageHealthCheck : IHealthCheck
    {
        private readonly IAdvertStorageService _storageService;
        public StorageHealthCheck(IAdvertStorageService storageService)
        {
            _storageService = storageService;
        }

        public async ValueTask<IHealthCheckResult> CheckAsync(CancellationToken cancellationToken = default)
        {
            var isStorageOk = await _storageService.CheckHealthAsync();
            return HealthCheckResult.FromStatus(isStorageOk ? CheckStatus.Healthy : CheckStatus.Unhealthy, "");
        }
    }
}
