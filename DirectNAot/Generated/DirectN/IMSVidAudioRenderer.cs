#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidaudiorenderer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37b0353f-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidAudioRenderer : IMSVidOutputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorenderer-put_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Volume(int lVol);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorenderer-get_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Volume(out int lVol);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorenderer-put_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Balance(int lBal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorenderer-get_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Balance(out int lBal);
}
