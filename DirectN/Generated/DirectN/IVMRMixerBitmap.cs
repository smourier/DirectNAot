#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrmixerbitmap
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1e673275-0257-40aa-af20-7c608d4a0428")]
public partial interface IVMRMixerBitmap
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixerbitmap-setalphabitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaBitmap(in VMRALPHABITMAP pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixerbitmap-updatealphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateAlphaBitmapParameters(in VMRALPHABITMAP pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixerbitmap-getalphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlphaBitmapParameters(out VMRALPHABITMAP pBmpParms);
}
