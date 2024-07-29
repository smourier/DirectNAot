#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ibpcsatellitetuner
[GeneratedComInterface, Guid("211a8765-03ac-11d1-8d13-00aa00bd8339")]
public partial interface IBPCSatelliteTuner : IAMTuner
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibpcsatellitetuner-get_defaultsubchanneltypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultSubChannelTypes(out int plDefaultVideoType, out int plDefaultAudioType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibpcsatellitetuner-put_defaultsubchanneltypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultSubChannelTypes(int lDefaultVideoType, int lDefaultAudioType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibpcsatellitetuner-istapingpermitted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTapingPermitted();
}
