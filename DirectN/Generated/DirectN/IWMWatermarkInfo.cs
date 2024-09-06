#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwatermarkinfo
[GeneratedComInterface, Guid("6f497062-f2e2-4624-8ea7-9dd40d81fc8d")]
public partial interface IWMWatermarkInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwatermarkinfo-getwatermarkentrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWatermarkEntryCount(WMT_WATERMARK_ENTRY_TYPE wmetType, out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwatermarkinfo-getwatermarkentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWatermarkEntry(WMT_WATERMARK_ENTRY_TYPE wmetType, uint dwEntryNum, out WMT_WATERMARK_ENTRY pEntry);
}
