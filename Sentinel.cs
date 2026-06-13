using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;

namespace Sentinel
{
    public class Sentinel : RocketPlugin
    {
        private GriefProtect _griefProtect;

        protected override void Load()
        {
            _griefProtect = new GriefProtect();
            _griefProtect.Register();
        }

        protected override void Unload()
        {
            if (_griefProtect != null)
            {
                _griefProtect.Unregister();
            }
        }
    }
}