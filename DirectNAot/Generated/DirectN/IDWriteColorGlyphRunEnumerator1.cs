namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritecolorglyphrunenumerator1
[GeneratedComInterface, Guid("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35")]
public partial interface IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritecolorglyphrunenumerator1-getcurrentrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IDWriteColorGlyphRunEnumerator1_GetCurrentRun(out nint colorGlyphRun); // renamed, see https://github.com/dotnet/runtime/issues/101240
}
