#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-type1_font
[StructLayout(LayoutKind.Sequential)]
public partial struct TYPE1_FONT
{
    public HANDLE hPFM;
    public HANDLE hPFB;
    public uint ulIdentifier;
}
