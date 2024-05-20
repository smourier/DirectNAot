#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_palette_global
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_PALETTE_GLOBAL
{
    public static readonly DD_PALETTE_GLOBAL Null = new();
    
    public nuint dwReserved1;
}
