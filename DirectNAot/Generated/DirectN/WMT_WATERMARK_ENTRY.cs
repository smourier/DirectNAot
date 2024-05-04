#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_watermark_entry
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_WATERMARK_ENTRY
{
    public WMT_WATERMARK_ENTRY_TYPE wmetType;
    public Guid clsid;
    public uint cbDisplayName;
    public PWSTR pwszDisplayName;
}
