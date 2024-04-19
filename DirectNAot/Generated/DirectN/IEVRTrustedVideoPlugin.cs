namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-ievrtrustedvideoplugin
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("83a4ce40-7710-494b-a893-a472049af630")]
public partial interface IEVRTrustedVideoPlugin
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrtrustedvideoplugin-isintrustedvideomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsInTrustedVideoMode([MarshalAs(UnmanagedType.U4)] out bool pYes);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrtrustedvideoplugin-canconstrict
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanConstrict([MarshalAs(UnmanagedType.U4)] out bool pYes);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrtrustedvideoplugin-setconstriction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConstriction(uint dwKPix);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrtrustedvideoplugin-disableimageexport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableImageExport([MarshalAs(UnmanagedType.U4)] bool bDisable);
}
