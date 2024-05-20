#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-lineattrs
[StructLayout(LayoutKind.Sequential)]
public partial struct LINEATTRS
{
    public uint fl;
    public uint iJoin;
    public uint iEndCap;
    public FLOAT_LONG elWidth;
    public float eMiterLimit;
    public uint cstyle;
    public nint pstyle;
    public FLOAT_LONG elStyleState;
}
