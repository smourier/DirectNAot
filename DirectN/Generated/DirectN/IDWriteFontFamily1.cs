﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfamily1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("da20d8ef-812a-4c43-9802-62ec4abd7adf")]
public partial interface IDWriteFontFamily1 : IDWriteFontFamily
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfamily1-getfontlocality
    [PreserveSig]
    DWRITE_LOCALITY GetFontLocality(uint listIndex);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfamily1-getfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFont(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFont3>))] out IDWriteFont3 font);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfamily1-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFaceReference(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
}
