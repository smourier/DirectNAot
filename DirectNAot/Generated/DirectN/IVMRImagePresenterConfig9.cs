namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrimagepresenterconfig9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("45c15cab-6e22-420a-8043-ae1f0ac02c7d")]
public partial interface IVMRImagePresenterConfig9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagepresenterconfig9-setrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingPrefs(uint dwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagepresenterconfig9-getrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingPrefs(out uint dwRenderFlags);
}
