﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextlayout1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9064d822-80a7-465c-a986-df65f78b8feb")]
public partial interface IDWriteTextLayout1 : IDWriteTextLayout
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-setpairkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPairKerning(BOOL isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-getpairkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPairKerning(uint currentPosition, out BOOL isPairKerningEnabled, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-setcharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-getcharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharacterSpacing(uint currentPosition, out float leadingSpacing, out float trailingSpacing, out float minimumAdvanceWidth, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
}
