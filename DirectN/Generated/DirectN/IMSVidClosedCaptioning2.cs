#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidclosedcaptioning2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e00cb864-a029-4310-9987-a873f5887d97")]
public partial interface IMSVidClosedCaptioning2 : IMSVidClosedCaptioning
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidclosedcaptioning2-get_service
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Service(out MSVidCCService On);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidclosedcaptioning2-put_service
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Service(MSVidCCService On);
}
