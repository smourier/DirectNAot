﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("07ddcd52-020e-4de8-ac33-6c953d83f92d")]
public partial interface IDWriteTextLayout3 : IDWriteTextLayout2
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout3-invalidatelayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InvalidateLayout();
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout3-setlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLineSpacing(in DWRITE_LINE_SPACING lineSpacingOptions);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout3-getlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLineSpacing(out DWRITE_LINE_SPACING lineSpacingOptions);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout3-getlinemetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IDWriteTextLayout3_GetLineMetrics(nint/* nint */ lineMetrics, uint maxLineCount, out uint actualLineCount); // renamed, see https://github.com/dotnet/runtime/issues/101240
}
