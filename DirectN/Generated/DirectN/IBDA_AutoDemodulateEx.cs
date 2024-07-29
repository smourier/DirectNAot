#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_autodemodulateex
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("34518d13-1182-48e6-b28f-b24987787326")]
public partial interface IBDA_AutoDemodulateEx : IBDA_AutoDemodulate
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_autodemodulateex-get_supporteddevicenodetypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedDeviceNodeTypes(uint ulcDeviceNodeTypesMax, out uint pulcDeviceNodeTypes, ref Guid pguidDeviceNodeTypes);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_autodemodulateex-get_supportedvideoformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedVideoFormats(out uint pulAMTunerModeType, out uint pulAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_autodemodulateex-get_auxinputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AuxInputCount(ref uint pulCompositeCount, ref uint pulSvideoCount);
}
