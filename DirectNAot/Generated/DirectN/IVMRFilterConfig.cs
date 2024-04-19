namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrfilterconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9e5530c5-7034-48b4-bb46-0b8a6efc8e36")]
public partial interface IVMRFilterConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-setimagecompositor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetImageCompositor(IVMRImageCompositor lpVMRImgCompositor);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-setnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumberOfStreams(uint dwMaxStreams);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-getnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfStreams(out uint pdwMaxStreams);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-setrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingPrefs(uint dwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-getrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingPrefs(out uint pdwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-setrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingMode(uint Mode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrfilterconfig-getrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingMode(out uint pMode);
}
