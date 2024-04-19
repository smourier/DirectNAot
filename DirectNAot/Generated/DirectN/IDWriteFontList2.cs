namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontlist2
[GeneratedComInterface, Guid("c0763a34-77af-445a-b735-08c37b0a5bf5")]
public partial interface IDWriteFontList2 : IDWriteFontList1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontlist2-getfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSet(out IDWriteFontSet1 fontSet);
}
