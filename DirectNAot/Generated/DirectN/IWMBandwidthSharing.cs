namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmbandwidthsharing
[GeneratedComInterface, Guid("ad694af1-f8d9-42f8-bc47-70311b0c4f9e")]
public partial interface IWMBandwidthSharing : IWMStreamList
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbandwidthsharing-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out Guid pguidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbandwidthsharing-settype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetType(in Guid guidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbandwidthsharing-getbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandwidth(out uint pdwBitrate, out uint pmsBufferWindow);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbandwidthsharing-setbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBandwidth(uint dwBitrate, uint msBufferWindow);
}
