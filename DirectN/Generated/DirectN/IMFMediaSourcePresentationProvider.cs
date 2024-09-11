#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasourcepresentationprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0e1d600a-c9f3-442d-8c51-a42d2d49452f")]
public partial interface IMFMediaSourcePresentationProvider
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasourcepresentationprovider-forceendofpresentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ForceEndOfPresentation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] IMFPresentationDescriptor pPresentationDescriptor);
}
