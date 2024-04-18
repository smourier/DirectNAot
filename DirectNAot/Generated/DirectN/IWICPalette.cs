namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicpalette
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICPalette
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializepredefined
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializePredefined(WICBitmapPaletteType ePaletteType, [MarshalAs(UnmanagedType.U4)] bool fAddTransparentColor);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializecustom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializeCustom(in uint pColors, uint cCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializefrombitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializeFromBitmap(IWICBitmapSource pISurface, uint cCount, [MarshalAs(UnmanagedType.U4)] bool fAddTransparentColor);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializefrompalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializeFromPalette(IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetType(out WICBitmapPaletteType pePaletteType);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-getcolorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-getcolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColors(uint cCount, out uint pColors, out uint pcActualColors);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-isblackwhite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsBlackWhite([MarshalAs(UnmanagedType.U4)] out bool pfIsBlackWhite);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-isgrayscale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsGrayscale([MarshalAs(UnmanagedType.U4)] out bool pfIsGrayscale);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-hasalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT HasAlpha([MarshalAs(UnmanagedType.U4)] out bool pfHasAlpha);
}
