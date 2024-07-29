#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-immendpoint
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1be09788-6894-4089-8586-9a2a6c265ac5")]
public partial interface IMMEndpoint
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immendpoint-getdataflow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataFlow(out EDataFlow pDataFlow);
}
