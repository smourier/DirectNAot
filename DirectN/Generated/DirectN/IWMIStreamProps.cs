#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmistreamprops
[GeneratedComInterface, Guid("6816dad3-2b4b-4c8e-8149-874c3483a753")]
public partial interface IWMIStreamProps
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmistreamprops-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
}
