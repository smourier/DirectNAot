#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetirqinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETIRQINFO
{
    public uint dwFlags;
}
