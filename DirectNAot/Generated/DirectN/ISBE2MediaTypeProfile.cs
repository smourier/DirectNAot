namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2mediatypeprofile
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f238267d-4671-40d7-997e-25dc32cfed2a")]
public partial interface ISBE2MediaTypeProfile
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2mediatypeprofile-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2mediatypeprofile-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(uint Index, out AM_MEDIA_TYPE ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2mediatypeprofile-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream(in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2mediatypeprofile-deletestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteStream(uint Index);
}
