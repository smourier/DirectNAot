#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSHOW_STREAM_DESC
{
    public uint VersionNo;
    public uint StreamId;
    public BOOL Default;
    public BOOL Creation;
    public uint Reserved;
}
