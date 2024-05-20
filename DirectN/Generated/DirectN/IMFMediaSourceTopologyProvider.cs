#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasourcetopologyprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0e1d6009-c9f3-442d-8c51-a42d2d49452f")]
public partial interface IMFMediaSourceTopologyProvider
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasourcetopologyprovider-getmediasourcetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaSourceTopology(IMFPresentationDescriptor pPresentationDescriptor, out IMFTopology ppTopology);
}
