#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddscaps
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSCAPS
{
    public uint dwCaps;
}
