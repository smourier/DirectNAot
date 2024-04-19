namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmprogress
[GeneratedComInterface, Guid("1dcb3a0c-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDMProgress
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress-begin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin(uint dwEstimatedTicks);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress-progress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Progress(uint dwTranspiredTicks);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End();
}
