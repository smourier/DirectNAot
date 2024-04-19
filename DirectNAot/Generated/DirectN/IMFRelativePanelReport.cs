namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfrelativepanelreport
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("f25362ea-2c0e-447f-81e2-755914cdc0c3")]
public partial interface IMFRelativePanelReport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrelativepanelreport-getrelativepanel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativePanel(out uint panel);
}
