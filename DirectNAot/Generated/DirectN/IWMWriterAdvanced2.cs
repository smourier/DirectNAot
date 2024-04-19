namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriteradvanced2
[GeneratedComInterface, Guid("962dc1ec-c046-4db8-9cc7-26ceae500817")]
public partial interface IWMWriterAdvanced2 : IWMWriterAdvanced
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced2-getinputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputSetting(uint dwInputNum, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced2-setinputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputSetting(uint dwInputNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
}
