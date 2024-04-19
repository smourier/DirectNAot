namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12deviceremovedextendeddatasettings
[GeneratedComInterface, Guid("82bc481c-6b9b-4030-aedb-7ee3d1df1e63")]
public partial interface ID3D12DeviceRemovedExtendedDataSettings
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12deviceremovedextendeddatasettings-setautobreadcrumbsenablement
    [PreserveSig]
    void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12deviceremovedextendeddatasettings-setpagefaultenablement
    [PreserveSig]
    void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12deviceremovedextendeddatasettings-setwatsondumpenablement
    [PreserveSig]
    void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement);
}
