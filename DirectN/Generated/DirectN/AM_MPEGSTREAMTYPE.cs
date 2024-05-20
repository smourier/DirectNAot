#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpegtype/ns-mpegtype-am_mpegstreamtype
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_MPEGSTREAMTYPE
{
    public uint dwStreamId;
    public uint dwReserved;
    public AM_MEDIA_TYPE mt;
    public InlineArrayByte_1 bFormat; // variable-length array placeholder
}
