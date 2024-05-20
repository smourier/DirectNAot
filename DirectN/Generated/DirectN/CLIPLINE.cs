#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-clipline
[StructLayout(LayoutKind.Sequential)]
public partial struct CLIPLINE
{
    public POINTFIX ptfxA;
    public POINTFIX ptfxB;
    public int lStyleState;
    public uint c;
    public InlineArrayRUN_1 arun; // variable-length array placeholder
}
