#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmeditor
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ff130ebc-a6c3-42a6-b401-c3382c3e08b3")]
public partial interface IWMDRMEditor
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmeditor-getdrmproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDRMProperty(PWSTR pwstrName, out WMT_ATTR_DATATYPE pdwType, nint /* byte array */ pValue, ref ushort pcbLength);
}
