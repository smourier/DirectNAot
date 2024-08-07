﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfamily2
[GeneratedComInterface, Guid("3ed49e77-a398-4261-b9cf-c126c2131ef3")]
public partial interface IDWriteFontFamily2 : IDWriteFontFamily1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfamily2-getmatchingfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts([In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontList2>))] out IDWriteFontList2 matchingFonts);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfamily2-getfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSet([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 fontSet);
}
