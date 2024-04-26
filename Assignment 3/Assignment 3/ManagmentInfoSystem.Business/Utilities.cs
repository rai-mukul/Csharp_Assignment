using System;
using System.IO;
using System.Reflection;

namespace ManagmentInfoSystem.Business
{
    public class Utilities
    {
        public static string GetDirectoryPath(string db)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            UriBuilder uri = new UriBuilder(assemblyLocation);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path) + db;
        }
    }
}
