#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamextendedseeking
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f9-8b62-11d0-a520-000000000000")]
public partial interface IAMExtendedSeeking : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-get_exseekcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExSeekCapabilities(ref int pExCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-get_markercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MarkerCount(ref int pMarkerCount);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-get_currentmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentMarker(ref int pCurrentMarker);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-getmarkertime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMarkerTime(int MarkerNum, ref double pMarkerTime);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-getmarkername
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMarkerName(int MarkerNum, out BSTR pbstrMarkerName);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-put_playbackspeed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PlaybackSpeed(double Speed);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendedseeking-get_playbackspeed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PlaybackSpeed(ref double pSpeed);
}
