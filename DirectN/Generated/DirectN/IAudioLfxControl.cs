#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nn-audioengineendpoint-iaudiolfxcontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("076a6922-d802-4f83-baf6-409d9ca11bfe")]
public partial interface IAudioLfxControl
{
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudiolfxcontrol-setlocaleffectsstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLocalEffectsState([MarshalAs(UnmanagedType.U4)] bool bEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudiolfxcontrol-getlocaleffectsstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalEffectsState([MarshalAs(UnmanagedType.U4)] out bool pbEnabled);
}
