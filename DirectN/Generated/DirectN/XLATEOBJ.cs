#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-xlateobj
[StructLayout(LayoutKind.Sequential)]
public partial struct XLATEOBJ
{
    public uint iUniq;
    public uint flXlate;
    public ushort iSrcType;
    public ushort iDstType;
    public uint cEntries;
    public nint pulXlate;
}
