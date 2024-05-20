#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersinkevent3
[GeneratedComInterface, Guid("735ad8d5-c259-48e9-81e7-d27953665b23")]
public partial interface IMSVidStreamBufferSinkEvent3 : IMSVidStreamBufferSinkEvent2
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent3-licensechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LicenseChange(int dwProt);
}
