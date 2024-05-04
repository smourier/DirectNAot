#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TIMEREVENT
{
    public ushort wDelay;
    public ushort wResolution;
    public nint lpFunction;
    public uint dwUser;
    public ushort wFlags;
    public ushort wReserved1;
}
