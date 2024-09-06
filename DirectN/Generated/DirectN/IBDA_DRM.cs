#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_drm
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f98d88b0-1992-4cd6-a6d9-b9afab99330d")]
public partial interface IBDA_DRM
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_drm-getdrmpairingstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDRMPairingStatus(out uint pdwStatus, out HRESULT phError);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_drm-performdrmpairing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PerformDRMPairing(BOOL fSync);
}
