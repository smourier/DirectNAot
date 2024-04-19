namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdevicecontrol
[GeneratedComInterface, Guid("1dcb3a14-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPDeviceControl
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-getdcstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDCStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pdwCapabilitiesMask);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-play
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Play();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-record
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Record(in WAVEFORMATEX pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevicecontrol-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(uint fuMode, int nOffset);
}
