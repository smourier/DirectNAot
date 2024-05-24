#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TID_EXTENSION
{
    public ushort wTidExt;
    public ushort wCount;
}
