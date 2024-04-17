using System;

namespace Win32InteropBuilder.Model
{
    [Flags]
    public enum Architecture
    {
        None = 0,
        X86 = 1,
        X64 = 2,
        Arm64 = 4,
        All = 7
    }
}
