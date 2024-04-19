namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmcodecinfo3
[GeneratedComInterface, Guid("7e51f487-4d93-4f98-8ab4-27d0565adc51")]
public partial interface IWMCodecInfo3 : IWMCodecInfo2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo3-getcodecformatprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecFormatProp(in Guid guidType, uint dwCodecIndex, uint dwFormatIndex, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo3-getcodecprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecProp(in Guid guidType, uint dwCodecIndex, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo3-setcodecenumerationsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCodecEnumerationSetting(in Guid guidType, uint dwCodecIndex, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, uint dwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo3-getcodecenumerationsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecEnumerationSetting(in Guid guidType, uint dwCodecIndex, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
}
