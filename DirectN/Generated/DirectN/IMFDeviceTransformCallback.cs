#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/nn-mftransform-imfdevicetransformcallback
[SupportedOSPlatform("windows10.0.17134")]
[GeneratedComInterface, Guid("6d5cb646-29ec-41fb-8179-8c4c6d750811")]
public partial interface IMFDeviceTransformCallback
{
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransformcallback-onbuffersent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnBufferSent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pCallbackAttributes, uint pinId);
}
