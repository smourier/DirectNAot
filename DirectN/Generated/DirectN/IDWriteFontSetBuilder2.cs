#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontsetbuilder2
[GeneratedComInterface, Guid("ee5ba612-b131-463c-8f4f-3189b9401e45")]
public partial interface IDWriteFontSetBuilder2 : IDWriteFontSetBuilder1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder2-addfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFont([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFile>))] IDWriteFontFile fontFile, uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [In][MarshalUsing(CountElementName = nameof(fontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, [In][MarshalUsing(CountElementName = nameof(propertyCount))] DWRITE_FONT_PROPERTY[] properties, uint propertyCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder2-addfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFile(PWSTR filePath);
}
