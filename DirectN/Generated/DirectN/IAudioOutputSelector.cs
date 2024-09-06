#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudiooutputselector
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bb515f69-94a7-429e-8b9c-271b3f11a3ab")]
public partial interface IAudioOutputSelector
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiooutputselector-getselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection(out uint pnIdSelected);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiooutputselector-setselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelection(uint nIdSelect, nint /* optional Guid* */ pguidEventContext);
}
