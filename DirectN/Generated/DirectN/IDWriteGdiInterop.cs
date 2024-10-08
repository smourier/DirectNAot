﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritegdiinterop
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1edd9491-9853-4299-898f-6432983b6f3a")]
public partial interface IDWriteGdiInterop
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createfontfromlogfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFromLOGFONT(in LOGFONTW logFont, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFont>))] out IDWriteFont font);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-convertfonttologfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertFontToLOGFONT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFont>))] IDWriteFont font, out LOGFONTW logFont, out BOOL isSystemFont);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-convertfontfacetologfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertFontFaceToLOGFONT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace font, out LOGFONTW logFont);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createfontfacefromhdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceFromHdc(HDC hdc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] out IDWriteFontFace fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createbitmaprendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapRenderTarget(HDC hdc, uint width, uint height, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteBitmapRenderTarget>))] out IDWriteBitmapRenderTarget renderTarget);
}
