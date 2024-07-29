#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderaccelerator
[GeneratedComInterface, Guid("bddc4d08-944d-4d52-a612-46c3fda07dd4")]
public partial interface IWMReaderAccelerator
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderaccelerator-getcodecinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecInterface(uint dwOutputNum, in Guid riid, out nint ppvCodecInterface);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderaccelerator-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(uint dwOutputNum, in WM_MEDIA_TYPE pSubtype);
}
