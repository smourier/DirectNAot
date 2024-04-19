namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudioinputselector
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4f03dc02-5e6e-4653-8f72-a030c123d598")]
public partial interface IAudioInputSelector
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioinputselector-getselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection(out uint pnIdSelected);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioinputselector-setselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelection(uint nIdSelect, nint/* nint */ pguidEventContext);
}
