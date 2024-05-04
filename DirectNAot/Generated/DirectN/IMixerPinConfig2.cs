#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpconfig/nn-mpconfig-imixerpinconfig2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ebf47182-8764-11d1-9e69-00c04fd7c15b")]
public partial interface IMixerPinConfig2 : IMixerPinConfig
{
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig2-setoverlaysurfacecolorcontrols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOverlaySurfaceColorControls(ref DDCOLORCONTROL pColorControl);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig2-getoverlaysurfacecolorcontrols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlaySurfaceColorControls(ref DDCOLORCONTROL pColorControl);
}
