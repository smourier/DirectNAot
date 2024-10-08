﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/nn-dwrite_2-idwritefontfallback
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("efa008f9-f7a1-48bf-b05c-f224713cc0ff")]
public partial interface IDWriteFontFallback
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontfallback-mapcharacters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapCharacters([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource>))] IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection?>))] IDWriteFontCollection? baseFontCollection, PWSTR baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, ref uint mappedLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFont>))] out IDWriteFont mappedFont, out float scale);
}
