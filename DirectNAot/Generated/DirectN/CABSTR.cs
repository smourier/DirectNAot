#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CABSTR
{
    public uint cElems;
    public nint pElems;
}
