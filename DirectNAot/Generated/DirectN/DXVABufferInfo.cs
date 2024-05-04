#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxvabufferinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVABufferInfo
{
    public nint pCompSurface;
    public uint DataOffset;
    public uint DataSize;
}
