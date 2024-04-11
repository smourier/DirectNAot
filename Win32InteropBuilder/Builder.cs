using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Win32MetadataReader;

namespace Win32InteropBuilder
{
    public abstract class Builder
    {
        public virtual BuilderContext CreateBuilderContext(string winMdPath) => new(winMdPath);
        public virtual void Build(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            using var stream = File.OpenRead(context.WinMdPath);
            using var pe = new PEReader(stream);
            var reader = pe.GetMetadataReader();
            var count = 0;
            foreach (var type in reader.TypeDefinitions.Select(reader.GetTypeDefinition))
            {
                var fn = reader.GetFullName(type);
                Console.WriteLine($"{count}: {fn}");
                count++;
            }
        }
    }
}
