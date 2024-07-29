#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmstatuscallback
[GeneratedComInterface, Guid("6d7cdc70-9888-11d3-8edc-00c04f6109cf")]
public partial interface IWMStatusCallback
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstatuscallback-onstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStatus(WMT_STATUS Status, HRESULT hr, WMT_ATTR_DATATYPE dwType, nint /* byte array */ pValue, nint pvContext);
}
