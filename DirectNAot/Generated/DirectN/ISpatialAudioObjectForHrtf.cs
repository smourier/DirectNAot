#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nn-spatialaudiohrtf-ispatialaudioobjectforhrtf
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("d7436ade-1978-4e14-aba0-555bd8eb83b4")]
public partial interface ISpatialAudioObjectForHrtf : ISpatialAudioObjectBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setgain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGain(float gain);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOrientation(in float orientation);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setenvironment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnvironment(SpatialAudioHrtfEnvironmentType environment);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setdistancedecay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDistanceDecay(in SpatialAudioHrtfDistanceDecay distanceDecay);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectforhrtf-setdirectivity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectivity(in SpatialAudioHrtfDirectivityUnion directivity);
}
