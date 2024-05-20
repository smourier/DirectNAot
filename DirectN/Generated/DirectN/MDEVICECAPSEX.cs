#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmddk/ns-mmddk-mdevicecapsex
[StructLayout(LayoutKind.Sequential)]
public partial struct MDEVICECAPSEX
{
    public uint cbSize;
    public nint pCaps;
}
