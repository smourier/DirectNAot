﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwriteglyphrunanalysis
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7d97dbf7-e085-42d4-81e3-6a883bded118")]
public partial interface IDWriteGlyphRunAnalysis
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteglyphrunanalysis-getalphatexturebounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, out FoundationRECT textureBounds);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteglyphrunanalysis-createalphatexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, FoundationRECT textureBounds, nint /* byte array */ alphaValues, uint bufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteglyphrunanalysis-getalphablendparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAlphaBlendParams(IDWriteRenderingParams renderingParams, out float blendGamma, out float blendEnhancedContrast, out float blendClearTypeLevel);
}
