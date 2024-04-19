namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_stream_type_info
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_STREAM_TYPE_INFO
{
    public Guid guidMajorType;
    public uint cbFormat;
}
