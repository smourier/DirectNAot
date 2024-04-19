namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmvideomediaprops
[GeneratedComInterface, Guid("96406bcf-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMVideoMediaProps : IWMMediaProps
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmvideomediaprops-getmaxkeyframespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxKeyFrameSpacing(out long pllTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmvideomediaprops-setmaxkeyframespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxKeyFrameSpacing(long llTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmvideomediaprops-getquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQuality(out uint pdwQuality);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmvideomediaprops-setquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetQuality(uint dwQuality);
}
