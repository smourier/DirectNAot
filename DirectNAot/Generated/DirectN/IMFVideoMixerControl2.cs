namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideomixercontrol2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8459616d-966e-4930-b658-54fa7e5a16d3")]
public partial interface IMFVideoMixerControl2 : IMFVideoMixerControl
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol2-setmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMixingPrefs(uint dwMixFlags);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideomixercontrol2-getmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMixingPrefs(out uint pdwMixFlags);
}
