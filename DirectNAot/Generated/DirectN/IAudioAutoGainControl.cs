#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudioautogaincontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("85401fd4-6de4-4b9d-9869-2d6753a82f3c")]
public partial interface IAudioAutoGainControl
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioautogaincontrol-getenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnabled([MarshalAs(UnmanagedType.U4)] out bool pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioautogaincontrol-setenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnabled([MarshalAs(UnmanagedType.U4)] bool bEnable, nint /* optional Guid* */ pguidEventContext);
}
