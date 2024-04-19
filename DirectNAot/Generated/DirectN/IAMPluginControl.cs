namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamplugincontrol
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0e26a181-f40c-4635-8786-976284b52981")]
public partial interface IAMPluginControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-getpreferredclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredClsid(in Guid subType, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-getpreferredclsidbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredClsidByIndex(uint index, out Guid subType, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-setpreferredclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreferredClsid(in Guid subType, nint/* nint */ clsid);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-isdisabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDisabled(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-getdisabledbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisabledByIndex(uint index, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-setdisabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisabled(in Guid clsid, [MarshalAs(UnmanagedType.U4)] bool disabled);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamplugincontrol-islegacydisabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLegacyDisabled(PWSTR dllName);
}
