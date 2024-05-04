#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmdevicecontrol
[GeneratedComInterface, Guid("1dcb3a04-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDMDeviceControl
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pdwCapabilitiesMask);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-play
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Play();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-record
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Record(in WAVEFORMATEX pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicecontrol-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(uint fuMode, int nOffset);
}
