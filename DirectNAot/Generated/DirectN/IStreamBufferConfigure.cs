namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferconfigure
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ce14dfae-4098-4af7-bbf7-d6511f835414")]
public partial interface IStreamBufferConfigure
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-setdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectory(PWSTR pszDirectoryName);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-getdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectory(out PWSTR ppszDirectoryName);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-setbackingfilecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackingFileCount(uint dwMin, uint dwMax);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-getbackingfilecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingFileCount(out uint pdwMin, out uint pdwMax);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-setbackingfileduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackingFileDuration(uint dwSeconds);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure-getbackingfileduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingFileDuration(out uint pdwSeconds);
}
