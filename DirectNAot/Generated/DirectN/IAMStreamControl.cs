namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamstreamcontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36b73881-c2c8-11cf-8b46-00805f6cef60")]
public partial interface IAMStreamControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamcontrol-startat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartAt(nint /* optional long* */ ptStart, uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamcontrol-stopat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopAt(nint /* optional long* */ ptStop, [MarshalAs(UnmanagedType.U4)] bool bSendExtra, uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamcontrol-getinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfo(out AM_STREAM_INFO pInfo);
}
