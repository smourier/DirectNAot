#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CLIPDATA
{
    public uint cbSize;
    public int ulClipFmt;
    public nint pClipData;
}
