#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmpacketsize
[GeneratedComInterface, Guid("cdfb97ab-188f-40b3-b643-5b7903975c59")]
public partial interface IWMPacketSize
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpacketsize-getmaxpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxPacketSize(out uint pdwMaxPacketSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpacketsize-setmaxpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxPacketSize(uint dwMaxPacketSize);
}
