namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontcollection3
[GeneratedComInterface, Guid("a4d055a6-f9e3-4e25-93b7-9e309f3af8e9")]
public partial interface IDWriteFontCollection3 : IDWriteFontCollection2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection3-getexpirationevent
    [PreserveSig]
    HANDLE GetExpirationEvent();
}
