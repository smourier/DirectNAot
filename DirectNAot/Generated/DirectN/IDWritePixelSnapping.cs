﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritepixelsnapping
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b")]
public partial interface IDWritePixelSnapping
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsPixelSnappingDisabled(nint/* nint */ clientDrawingContext, [MarshalAs(UnmanagedType.U4)] out bool isDisabled);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritepixelsnapping-getcurrenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCurrentTransform(nint/* nint */ clientDrawingContext, out DWRITE_MATRIX transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritepixelsnapping-getpixelsperdip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPixelsPerDip(nint/* nint */ clientDrawingContext, out float pixelsPerDip);
}
