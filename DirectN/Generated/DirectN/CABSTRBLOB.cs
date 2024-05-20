#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CABSTRBLOB
{
    public uint cElems;
    public nint pElems;
}
