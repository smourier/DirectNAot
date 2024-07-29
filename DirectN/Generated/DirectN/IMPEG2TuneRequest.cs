#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-impeg2tunerequest
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("eb7d987f-8a01-42ad-b8ae-574deee44d1a")]
public partial interface IMPEG2TuneRequest : ITuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2tunerequest-get_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TSID(out int TSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2tunerequest-put_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TSID(int TSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2tunerequest-get_progno
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProgNo(out int ProgNo);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2tunerequest-put_progno
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProgNo(int ProgNo);
}
