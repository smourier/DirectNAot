#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-ibasicvideo2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("329bb360-f6ea-11d1-9038-00a0c9697298")]
public partial interface IBasicVideo2 : IBasicVideo
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo2-getpreferredaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredAspectRatio(out int plAspectX, out int plAspectY);
}
