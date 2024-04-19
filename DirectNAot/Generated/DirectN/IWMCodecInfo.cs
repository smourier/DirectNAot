namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmcodecinfo
[GeneratedComInterface, Guid("a970f41e-34de-4a98-b3ba-e4b3ca7528f0")]
public partial interface IWMCodecInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo-getcodecinfocount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecInfoCount(in Guid guidType, out uint pcCodecs);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo-getcodecformatcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecFormatCount(in Guid guidType, uint dwCodecIndex, out uint pcFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo-getcodecformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecFormat(in Guid guidType, uint dwCodecIndex, uint dwFormatIndex, out IWMStreamConfig ppIStreamConfig);
}
