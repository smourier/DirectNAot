#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritelocalizedstrings
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("08256209-099a-4b34-b86d-c22b110e7771")]
public partial interface IDWriteLocalizedStrings
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getcount
    [PreserveSig]
    uint GetCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-findlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindLocaleName(PWSTR localeName, out uint index, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getlocalenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleNameLength(uint index, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleName(uint index, [MarshalUsing(CountElementName = nameof(size))] PWSTR localeName, uint size);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getstringlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringLength(uint index, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetString(uint index, [MarshalUsing(CountElementName = nameof(size))] PWSTR stringBuffer, uint size);
}
