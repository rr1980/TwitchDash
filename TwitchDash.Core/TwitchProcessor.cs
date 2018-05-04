using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using TwitchDash.Common;
using TwitchDash.Models;

namespace TwitchDash.Core
{
    internal class TwitchProcessor : ITwitchProcessor
    {
        private readonly ILogger<TwitchProcessor> _logger;
        private readonly AppSettings _config;

        public TwitchProcessor(IOptions<AppSettings> config, ILogger<TwitchProcessor> logger)
        {
            _logger = logger;
            _config = config.Value;
        }

        public async Task Run()
        {
            _logger.LogInformation($"{_config.ConsoleTitle} start...");
            var t = process();
            _logger.LogInformation($"{_config.ConsoleTitle} wait...");


            await t;
            _logger.LogInformation($"{_config.ConsoleTitle} rdy...");
        }

        private async Task process()
        {
            _logger.LogInformation($"process start...");
            await Task.Delay(2000);
            _logger.LogInformation($"process rdy...");
        }
    }
}
