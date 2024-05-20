#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontsetbuilder1
[GeneratedComInterface, Guid("3ff7715f-3cdc-4dc6-9b72-ec5621dccafd")]
public partial interface IDWriteFontSetBuilder1 : IDWriteFontSetBuilder
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder1-addfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFile(IDWriteFontFile fontFile);
}
