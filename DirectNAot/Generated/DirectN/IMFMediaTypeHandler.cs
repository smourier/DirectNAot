namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediatypehandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e93dcf6c-4b07-4e1e-8123-aa16ed6eadf5")]
public partial interface IMFMediaTypeHandler
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-ismediatypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMediaTypeSupported(IMFMediaType pMediaType, nint/* nint */ ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmediatypecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeCount(out uint pdwTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmediatypebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeByIndex(uint dwIndex, out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-setcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentMediaType(IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentMediaType(out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMajorType(out Guid pguidMajorType);
}
