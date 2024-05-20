#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CAFILETIME
{
    public uint cElems;
    public nint pElems;
}
