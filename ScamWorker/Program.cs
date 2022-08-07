using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ScamWorker.Internal;

namespace ScamWorker
{
    public static class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();
        
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.Configure<WorkerOptions>(Configuration.WorkerConfigSection);
                    services.AddHostedService<Worker>();
                });
        }
    }
}
