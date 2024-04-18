﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritetextformat3
[GeneratedComInterface, Guid("6d3b5641-e550-430d-a85b-b7bf48a93427")]
public partial interface IDWriteTextFormat3 : IDWriteTextFormat2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat3-setfontaxisvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontAxisValues(in DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat3-getfontaxisvaluecount
    [PreserveSig]
    public uint GetFontAxisValueCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat3-getfontaxisvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontAxisValues(out DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat3-getautomaticfontaxes
    [PreserveSig]
    public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat3-setautomaticfontaxes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);
}
