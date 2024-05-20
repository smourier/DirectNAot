#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdevice2
[GeneratedComInterface, Guid("420d16ad-c97d-4e00-82aa-00e9f4335ddd")]
public partial interface IMDSPDevice2 : IMDSPDevice
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice2-getstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorage(PWSTR pszStorageName, out IMDSPStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice2-getformatsupport2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatSupport2(uint dwFlags, out nint ppAudioFormatEx, out uint pnAudioFormatCount, out nint ppVideoFormatEx, out uint pnVideoFormatCount, out nint ppFileType, out uint pnFileTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice2-getspecifypropertypages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifyPropertyPages(out ISpecifyPropertyPages ppSpecifyPropPages, out nint pppUnknowns, out uint pcUnks);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice2-getcanonicalname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCanonicalName([MarshalUsing(CountElementName = nameof(nMaxChars))] PWSTR pwszPnPName, uint nMaxChars);
}
