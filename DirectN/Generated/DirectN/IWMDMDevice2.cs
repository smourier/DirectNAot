#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmdevice2
[GeneratedComInterface, Guid("e34f3d37-9d67-4fc1-9252-62d28b2f8b55")]
public partial interface IWMDMDevice2 : IWMDMDevice
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice2-getstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorage(PWSTR pszStorageName, out IWMDMStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice2-getformatsupport2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatSupport2(uint dwFlags, out nint ppAudioFormatEx, out uint pnAudioFormatCount, out nint ppVideoFormatEx, out uint pnVideoFormatCount, out nint ppFileType, out uint pnFileTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice2-getspecifypropertypages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifyPropertyPages(out ISpecifyPropertyPages ppSpecifyPropPages, out nint pppUnknowns, out uint pcUnks);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice2-getcanonicalname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCanonicalName([MarshalUsing(CountElementName = nameof(nMaxChars))] PWSTR pwszPnPName, uint nMaxChars);
}
