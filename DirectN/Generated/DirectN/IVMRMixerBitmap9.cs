#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrmixerbitmap9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ced175e5-1935-4820-81bd-ff6ad00c9108")]
public partial interface IVMRMixerBitmap9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixerbitmap9-setalphabitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaBitmap(in VMR9AlphaBitmap pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixerbitmap9-updatealphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateAlphaBitmapParameters(in VMR9AlphaBitmap pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixerbitmap9-getalphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlphaBitmapParameters(out VMR9AlphaBitmap pBmpParms);
}
