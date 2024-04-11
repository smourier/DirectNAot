using System;

namespace Win32InteropBuilder
{
    public class BuilderContext
    {
        public BuilderContext(string winMdPath)
        {
            ArgumentNullException.ThrowIfNull(winMdPath);
            WinMdPath = winMdPath;
        }

        public string WinMdPath { get; }

    }
}
