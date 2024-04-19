namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmdxva/nn-wmdxva-iwmcodecamvideoaccelerator
[GeneratedComInterface, Guid("d98ee251-34e0-4a2d-9312-9b4c788d9fa1")]
public partial interface IWMCodecAMVideoAccelerator
{
    // https://learn.microsoft.com/windows/win32/api/wmdxva/nf-wmdxva-iwmcodecamvideoaccelerator-setacceleratorinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAcceleratorInterface(IAMVideoAccelerator pIAMVA);
    
    // https://learn.microsoft.com/windows/win32/api/wmdxva/nf-wmdxva-iwmcodecamvideoaccelerator-negotiateconnection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateConnection(in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/wmdxva/nf-wmdxva-iwmcodecamvideoaccelerator-setplayernotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayerNotify(IWMPlayerTimestampHook pHook);
}
