#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideomixercontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a5c6c53f-c202-4aa5-9695-175ba8c508a5")]
public partial interface IMFVideoMixerControl
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol-setstreamzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamZOrder(uint dwStreamID, uint dwZ);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol-getstreamzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamZOrder(uint dwStreamID, out uint pdwZ);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol-setstreamoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamOutputRect(uint dwStreamID, in MFVideoNormalizedRect pnrcOutput);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol-getstreamoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamOutputRect(uint dwStreamID, out MFVideoNormalizedRect pnrcOutput);
}
