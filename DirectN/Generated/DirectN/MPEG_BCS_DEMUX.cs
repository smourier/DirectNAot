#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_bcs_demux
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_BCS_DEMUX
{
    public uint AVMGraphId;
}
