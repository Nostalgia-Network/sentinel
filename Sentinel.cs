using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using System;

namespace Sentinel
{
    public class Sentinel : RocketPlugin
    {
        protected override void Load()
        {
            // The standard plugin load message
            Logger.Log($"{Name} {Assembly.GetName().Version} has been loaded!", ConsoleColor.Yellow);
            
            // Your custom branding/info message
            Logger.Log("Sentinel is now monitoring server events. Report issues on GitHub.", ConsoleColor.Cyan);
        }

        protected override void Unload()
        {
            Logger.Log($"{Name} has been unloaded!", ConsoleColor.Yellow);
        }
    }
}