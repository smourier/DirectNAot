#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmmessageparser
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a73a0072-25a0-4c99-b4a5-ede8101a6c39")]
public partial interface IWMDRMMessageParser
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmmessageparser-parseregistrationreqmsg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseRegistrationReqMsg(nint /* byte array */ pbRegistrationReqMsg, uint cbRegistrationReqMsg, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppDeviceCert, out DRM_VAL16 pDeviceSerialNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmmessageparser-parselicenserequestmsg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseLicenseRequestMsg(nint /* byte array */ pbLicenseRequestMsg, uint cbLicenseRequestMsg, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppDeviceCert, out DRM_VAL16 pDeviceSerialNumber, out BSTR pbstrAction);
}
