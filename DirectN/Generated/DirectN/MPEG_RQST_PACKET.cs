#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_rqst_packet
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_RQST_PACKET
{
    public uint dwLength;
    public nint pSection;
}
