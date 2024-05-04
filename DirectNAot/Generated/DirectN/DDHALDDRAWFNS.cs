#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHALDDRAWFNS
{
    public uint dwSize;
    public nint lpSetInfo;
    public nint lpVidMemAlloc;
    public nint lpVidMemFree;
}
