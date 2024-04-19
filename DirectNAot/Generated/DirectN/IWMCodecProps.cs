namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcodecprops
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2573e11a-f01a-4fdd-a98d-63b8e0ba9589")]
public partial interface IWMCodecProps
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecprops-getformatprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatProp(ref DMO_MEDIA_TYPE pmt, PWSTR pszName, ref WMT_PROP_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecprops-getcodecprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecProp(uint dwFormat, PWSTR pszName, ref WMT_PROP_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
}
