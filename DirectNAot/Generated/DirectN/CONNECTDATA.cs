#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-connectdata
[StructLayout(LayoutKind.Sequential)]
public partial struct CONNECTDATA
{
    public nint pUnk;
    public uint dwCookie;
}
