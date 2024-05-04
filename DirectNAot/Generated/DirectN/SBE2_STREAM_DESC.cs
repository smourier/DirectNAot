#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/ns-sbe-sbe2_stream_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct SBE2_STREAM_DESC
{
    public uint Version;
    public uint StreamId;
    public uint Default;
    public uint Reserved;
}
