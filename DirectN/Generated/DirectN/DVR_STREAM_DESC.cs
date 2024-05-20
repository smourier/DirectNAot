#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/ns-sbe-dvr_stream_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DVR_STREAM_DESC
{
    public uint Version;
    public uint StreamId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Default;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Creation;
    public uint Reserved;
    public Guid guidSubMediaType;
    public Guid guidFormatType;
    public AM_MEDIA_TYPE MediaType;
}
