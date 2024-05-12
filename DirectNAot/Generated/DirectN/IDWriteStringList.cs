#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritestringlist
[GeneratedComInterface, Guid("cfee3140-1157-47ca-8b85-31bfcf3f2d0e")]
public partial interface IDWriteStringList
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritestringlist-getcount
    [PreserveSig]
    uint GetCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritestringlist-getlocalenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleNameLength(uint listIndex, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritestringlist-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleName(uint listIndex, [MarshalUsing(CountElementName = nameof(size))] out PWSTR localeName, uint size);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritestringlist-getstringlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringLength(uint listIndex, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritestringlist-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetString(uint listIndex, [MarshalUsing(CountElementName = nameof(stringBufferSize))] out PWSTR stringBuffer, uint stringBufferSize);
}
