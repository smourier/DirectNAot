#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-itunercap
[GeneratedComInterface, Guid("e60dfa45-8d56-4e65-a8ab-d6be9412c249")]
public partial interface ITunerCap
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunercap-get_supportednetworktypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedNetworkTypes(uint ulcNetworkTypesMax, out uint pulcNetworkTypes, ref Guid pguidNetworkTypes);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunercap-get_supportedvideoformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedVideoFormats(out uint pulAMTunerModeType, out uint pulAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunercap-get_auxinputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AuxInputCount(ref uint pulCompositeCount, ref uint pulSvideoCount);
}
