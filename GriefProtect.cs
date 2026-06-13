using Rocket.Core.Logging;
using System;

namespace Sentinel
{
    public class GriefProtect
    {
        public void Register()
        {
            Logger.Log("GriefProtect events registered.", ConsoleColor.Green);
        }

        public void Unregister()
        {
            Logger.Log("GriefProtect events unregistered.", ConsoleColor.Green);
        }
    }
}