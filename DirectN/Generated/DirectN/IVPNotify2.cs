#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vpnotify/nn-vpnotify-ivpnotify2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ebf47183-8764-11d1-9e69-00c04fd7c15b")]
public partial interface IVPNotify2 : IVPNotify
{
    // https://learn.microsoft.com/windows/win32/api/vpnotify/nf-vpnotify-ivpnotify2-setvpsyncmaster
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVPSyncMaster([MarshalAs(UnmanagedType.U4)] bool bVPSyncMaster);
    
    // https://learn.microsoft.com/windows/win32/api/vpnotify/nf-vpnotify-ivpnotify2-getvpsyncmaster
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVPSyncMaster([MarshalAs(UnmanagedType.U4)] ref bool pbVPSyncMaster);
}
