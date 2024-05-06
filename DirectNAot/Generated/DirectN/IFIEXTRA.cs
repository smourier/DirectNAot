#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-ifiextra
[StructLayout(LayoutKind.Sequential)]
public partial struct IFIEXTRA
{
    public uint ulIdentifier;
    public int dpFontSig;
    public uint cig;
    public int dpDesignVector;
    public int dpAxesInfoW;
    public InlineArrayUInt32_1 aulReserved; // variable-length array placeholder
}
