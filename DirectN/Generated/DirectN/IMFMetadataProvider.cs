#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmetadataprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("56181d2d-e221-4adb-b1c8-3cee6a53f76f")]
public partial interface IMFMetadataProvider
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadataprovider-getmfmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMFMetadata(IMFPresentationDescriptor pPresentationDescriptor, uint dwStreamIdentifier, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMetadata>))] out IMFMetadata ppMFMetadata);
}
