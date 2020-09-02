using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BlindExplosion
{
    public sealed class Config : IConfig
    {
        [Description("Determines if the plugin should be enabled or disabled.")]
        public bool IsEnabled { get; set; }
    }
}
