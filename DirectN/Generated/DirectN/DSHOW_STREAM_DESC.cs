#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSHOW_STREAM_DESC
{
    public uint VersionNo;
    public uint StreamId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Default;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Creation;
    public uint Reserved;
}
