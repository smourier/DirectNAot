using System;

namespace Win32InteropBuilder
{
    public class BuilderContext
    {
        public BuilderContext(BuilderConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            Configuration = configuration;
        }

        public BuilderConfiguration Configuration { get; }
    }
}
