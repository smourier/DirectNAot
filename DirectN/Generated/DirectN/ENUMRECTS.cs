#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-enumrects
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMRECTS
{
    public uint c;
    public InlineArrayRECTL_1 arcl; // variable-length array placeholder
}
