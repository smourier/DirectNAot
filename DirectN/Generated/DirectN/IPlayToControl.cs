#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-iplaytocontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("607574eb-f4b6-45c1-b08c-cb715122901d")]
public partial interface IPlayToControl
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-iplaytocontrol-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect(IMFSharingEngineClassFactory pFactory);
    
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-iplaytocontrol-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
}
