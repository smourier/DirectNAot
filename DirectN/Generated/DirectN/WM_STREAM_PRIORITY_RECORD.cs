#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_stream_priority_record
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct WM_STREAM_PRIORITY_RECORD
{
    public ushort wStreamNumber;
    public BOOL fMandatory;
}
