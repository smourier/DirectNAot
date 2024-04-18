﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwriterenderingparams
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75")]
public partial interface IDWriteRenderingParams
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriterenderingparams-getgamma
    [PreserveSig]
    public float GetGamma();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriterenderingparams-getenhancedcontrast
    [PreserveSig]
    public float GetEnhancedContrast();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriterenderingparams-getcleartypelevel
    [PreserveSig]
    public float GetClearTypeLevel();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriterenderingparams-getpixelgeometry
    [PreserveSig]
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriterenderingparams-getrenderingmode
    [PreserveSig]
    public DWRITE_RENDERING_MODE GetRenderingMode();
}
