#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vpnotify/nn-vpnotify-ivpnotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c76794a1-d6c5-11d0-9e69-00c04fd7c15b")]
public partial interface IVPNotify : IVPBaseNotify
{
    // https://learn.microsoft.com/windows/win32/api/vpnotify/nf-vpnotify-ivpnotify-setdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeinterlaceMode(AMVP_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/vpnotify/nf-vpnotify-ivpnotify-getdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlaceMode(ref AMVP_MODE pMode);
}
