namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamdeviceremoval
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("f90a6130-b658-11d2-ae49-0000f8754b99")]
public partial interface IAMDeviceRemoval
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdeviceremoval-deviceinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceInfo(out Guid pclsidInterfaceClass, out PWSTR pwszSymbolicLink);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdeviceremoval-reassociate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reassociate();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdeviceremoval-disassociate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disassociate();
}
