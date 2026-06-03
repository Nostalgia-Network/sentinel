using System;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace Sentinel
{
    public class Sentinel : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log($"{Name} {Assembly.GetName().Version} has been loaded!", ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            Logger.Log($"{Name} has been unloaded!", ConsoleColor.Yellow);
        }
    }
}
