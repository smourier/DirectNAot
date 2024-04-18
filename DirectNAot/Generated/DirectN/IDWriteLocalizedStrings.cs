namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritelocalizedstrings
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("08256209-099a-4b34-b86d-c22b110e7771")]
public partial interface IDWriteLocalizedStrings
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getcount
    [PreserveSig]
    public uint GetCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-findlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FindLocaleName(PWSTR localeName, out uint index, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getlocalenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLocaleNameLength(uint index, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLocaleName(uint index, out PWSTR localeName, uint size);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getstringlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStringLength(uint index, out uint length);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritelocalizedstrings-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetString(uint index, out PWSTR stringBuffer, uint size);
}
