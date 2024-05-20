#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidfileplayback
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37b03539-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidFilePlayback : IMSVidPlayback
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfileplayback-get_filename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FileName(out BSTR FileName);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfileplayback-put_filename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FileName(BSTR FileName);
}
