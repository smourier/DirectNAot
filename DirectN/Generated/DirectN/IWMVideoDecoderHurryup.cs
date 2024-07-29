#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmvideodecoderhurryup
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("352bb3bd-2d4d-4323-9e71-dcdcfbd53ca6")]
public partial interface IWMVideoDecoderHurryup
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideodecoderhurryup-sethurryup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHurryup(int lHurryup);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideodecoderhurryup-gethurryup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHurryup(ref int plHurryup);
}
