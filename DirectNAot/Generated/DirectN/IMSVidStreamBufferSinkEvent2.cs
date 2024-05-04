#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersinkevent2
[GeneratedComInterface, Guid("3d7a5166-72d7-484b-a06f-286187b80ca1")]
public partial interface IMSVidStreamBufferSinkEvent2 : IMSVidStreamBufferSinkEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent2-encryptionon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EncryptionOn();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent2-encryptionoff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EncryptionOff();
}
