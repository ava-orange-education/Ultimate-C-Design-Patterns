using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public sealed class ConfigService
    {
        private static readonly Lazy<Task<ConfigService>> _instance = new Lazy<Task<ConfigService>>(() => CreateAsync());

        private Dictionary<string, string> _settings;

        private ConfigService(Dictionary<string, string> settings)
        {
            _settings = settings;
        }

        public static Task<ConfigService> Instance => _instance.Value;

        private static async Task<ConfigService> CreateAsync()
        {
            var settings = await LoadRemoteSettingsAsync();
            return new ConfigService(settings);
        }

        private static async Task<Dictionary<string, string>> LoadRemoteSettingsAsync()
        {
            await Task.Delay(100); // Simulate network call
            return new Dictionary<string, string> { ["FeatureX"] = "true" };
        }

        public string Get(string key) => _settings.TryGetValue(key, out var value) ? value : null;
    }

}
