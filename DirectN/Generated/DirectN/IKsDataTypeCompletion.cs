#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("827d1a0e-0f73-11d2-b27a-00a0c9223196")]
public partial interface IKsDataTypeCompletion
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsCompleteMediaType(HANDLE FilterHandle, uint PinFactoryId, ref AM_MEDIA_TYPE AmMediaType);
}
