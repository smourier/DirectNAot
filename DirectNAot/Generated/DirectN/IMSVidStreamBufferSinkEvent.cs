namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersinkevent
[GeneratedComInterface, Guid("f798a36b-b05b-4bbe-9703-eaea7d61cd51")]
public partial interface IMSVidStreamBufferSinkEvent : IMSVidOutputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent-certificatefailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CertificateFailure();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent-certificatesuccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CertificateSuccess();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent-writefailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteFailure();
}
