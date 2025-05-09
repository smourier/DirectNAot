#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/imfmediastreamsourcesamplerequest
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("380b9af9-a85b-4e78-a2af-ea5ce645c6b4")]
public partial interface IMFMediaStreamSourceSampleRequest
{
    // https://learn.microsoft.com/windows/win32/medfound/imfmediastreamsourcesamplerequest-setsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample?>))] IMFSample? value);
}
