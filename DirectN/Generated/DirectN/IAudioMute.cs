#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudiomute
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("df45aeea-b74a-4b6b-afad-2366b6aa012e")]
public partial interface IAudioMute
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiomute-setmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMute(BOOL bMuted, nint /* optional Guid* */ pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiomute-getmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMute(out BOOL pbMuted);
}
