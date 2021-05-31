using System;
using System.IO;

namespace GameShop.Storage
{
    class StorageConfig
    {
        public static string root = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Game Shop");
    }
}
