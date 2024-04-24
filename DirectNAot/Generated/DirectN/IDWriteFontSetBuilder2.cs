namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontsetbuilder2
[GeneratedComInterface, Guid("ee5ba612-b131-463c-8f4f-3189b9401e45")]
public partial interface IDWriteFontSetBuilder2 : IDWriteFontSetBuilder1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder2-addfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFont(IDWriteFontFile fontFile, uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [MarshalUsing(CountElementName = nameof(fontAxisValueCount))] in DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(CountElementName = nameof(fontAxisRangeCount))] in DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, [MarshalUsing(CountElementName = nameof(propertyCount))] in DWRITE_FONT_PROPERTY[] properties, uint propertyCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder2-addfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFile(PWSTR filePath);
}
