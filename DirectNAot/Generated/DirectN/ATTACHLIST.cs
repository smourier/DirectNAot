#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ATTACHLIST
{
    public uint dwFlags;
    public nint lpLink;
    public nint lpAttached;
    public nint lpIAttached;
}
