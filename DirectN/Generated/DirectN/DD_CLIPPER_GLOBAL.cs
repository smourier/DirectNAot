#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_clipper_global
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CLIPPER_GLOBAL
{
    public static readonly DD_CLIPPER_GLOBAL Null = new();
    
    public nuint dwReserved1;
}
