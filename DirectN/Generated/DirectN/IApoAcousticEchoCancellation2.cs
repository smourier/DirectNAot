#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f235855f-f06d-45b3-a63f-ee4b71509dc2")]
public partial interface IApoAcousticEchoCancellation2 : IApoAcousticEchoCancellation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesiredReferenceStreamProperties(out APO_REFERENCE_STREAM_PROPERTIES pProperties);
}
