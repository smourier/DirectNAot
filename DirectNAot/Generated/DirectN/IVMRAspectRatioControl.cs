namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmraspectratiocontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ede80b5c-bad6-4623-b537-65586c9f8dfd")]
public partial interface IVMRAspectRatioControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmraspectratiocontrol-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint lpdwARMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmraspectratiocontrol-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint dwARMode);
}
