namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/nn-evr9-imfvideomixerbitmap
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("814c7b20-0fdb-4eec-af8f-f957c8f69edc")]
public partial interface IMFVideoMixerBitmap
{
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideomixerbitmap-setalphabitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaBitmap(in MFVideoAlphaBitmap pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideomixerbitmap-clearalphabitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearAlphaBitmap();
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideomixerbitmap-updatealphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateAlphaBitmapParameters(in MFVideoAlphaBitmapParams pBmpParms);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideomixerbitmap-getalphabitmapparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlphaBitmapParameters(out MFVideoAlphaBitmapParams pBmpParms);
}
