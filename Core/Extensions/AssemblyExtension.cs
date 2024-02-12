using System.Reflection;

namespace Core.Extensions
{
    internal static class AssemblyExtension
    {
        public static async Task<string> ReadResourceAsync(this Assembly assembly, string name)
        {
            string resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(name));

            using Stream stream = assembly.GetManifestResourceStream(resourcePath)!;
            using StreamReader reader = new(stream);
            return await reader.ReadToEndAsync();
        }

        public static string ReadResource(this Assembly assembly, string name)
        {
            string resourcePath = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(name));

            using Stream stream = assembly.GetManifestResourceStream(resourcePath)!;
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }

    }
}
