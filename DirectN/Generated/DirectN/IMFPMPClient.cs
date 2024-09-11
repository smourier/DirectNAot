#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpmpclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6c4e655d-ead8-4421-b6b9-54dcdbbdf820")]
public partial interface IMFPMPClient
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmpclient-setpmphost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPMPHost([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMPHost>))] IMFPMPHost pPMPHost);
}
