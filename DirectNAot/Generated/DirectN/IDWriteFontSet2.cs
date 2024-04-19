namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontset2
[GeneratedComInterface, Guid("dc7ead19-e54c-43af-b2da-4e2b79ba3f7f")]
public partial interface IDWriteFontSet2 : IDWriteFontSet1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset2-getexpirationevent
    [PreserveSig]
    HANDLE GetExpirationEvent();
}
