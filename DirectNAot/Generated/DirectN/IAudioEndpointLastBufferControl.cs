#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nn-audioengineendpoint-iaudioendpointlastbuffercontrol
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f8520dd3-8f9d-4437-9861-62f584c33dd6")]
public partial interface IAudioEndpointLastBufferControl
{
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudioendpointlastbuffercontrol-islastbuffercontrolsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsLastBufferControlSupported();
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudioendpointlastbuffercontrol-releaseoutputdatapointerforlastbuffer
    [PreserveSig]
    void ReleaseOutputDataPointerForLastBuffer(in APO_CONNECTION_PROPERTY pConnectionProperty);
}
