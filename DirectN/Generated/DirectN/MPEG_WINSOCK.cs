#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_winsock
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_WINSOCK
{
    public uint AVMGraphId;
}
