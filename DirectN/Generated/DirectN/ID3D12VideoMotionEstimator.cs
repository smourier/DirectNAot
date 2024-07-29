#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videomotionestimator
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("33fdae0e-098b-428f-87bb-34b695de08f8")]
public partial interface ID3D12VideoMotionEstimator : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videomotionestimator-getdesc
    [PreserveSig]
    D3D12_VIDEO_MOTION_ESTIMATOR_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videomotionestimator-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, out nint /* void */ ppProtectedSession);
}
