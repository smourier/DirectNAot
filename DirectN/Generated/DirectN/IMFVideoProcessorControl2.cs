#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideoprocessorcontrol2
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("bde633d3-e1dc-4a7f-a693-bbae399c4a20")]
public partial interface IMFVideoProcessorControl2 : IMFVideoProcessorControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol2-setrotationoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotationOverride(uint uiRotation);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol2-enablehardwareeffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableHardwareEffects([MarshalAs(UnmanagedType.U4)] bool fEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol2-getsupportedhardwareeffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedHardwareEffects(out uint puiSupport);
}
