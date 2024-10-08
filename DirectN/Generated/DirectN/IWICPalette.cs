﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicpalette
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICPalette
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializepredefined
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializePredefined(WICBitmapPaletteType ePaletteType, BOOL fAddTransparentColor);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializecustom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeCustom([In][MarshalUsing(CountElementName = nameof(cCount))] uint[] pColors, uint cCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializefrombitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromBitmap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pISurface, uint cCount, BOOL fAddTransparentColor);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-initializefrompalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICPalette>))] IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out WICBitmapPaletteType pePaletteType);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-getcolorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-getcolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColors(uint cCount, [In][Out][MarshalUsing(CountElementName = nameof(cCount))] uint[] pColors, out uint pcActualColors);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-isblackwhite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsBlackWhite(out BOOL pfIsBlackWhite);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-isgrayscale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsGrayscale(out BOOL pfIsGrayscale);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpalette-hasalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasAlpha(out BOOL pfHasAlpha);
}
