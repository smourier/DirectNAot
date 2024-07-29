#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmpacketsize2
[GeneratedComInterface, Guid("8bfc2b9e-b646-4233-a877-1c6a079669dc")]
public partial interface IWMPacketSize2 : IWMPacketSize
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpacketsize2-getminpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinPacketSize(out uint pdwMinPacketSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpacketsize2-setminpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMinPacketSize(uint dwMinPacketSize);
}
