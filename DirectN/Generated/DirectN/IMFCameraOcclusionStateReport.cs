#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameraocclusionstatereport
[GeneratedComInterface, Guid("1640b2cf-74da-4462-a43b-b76d3bdc1434")]
public partial interface IMFCameraOcclusionStateReport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraocclusionstatereport-getocclusionstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOcclusionState(out uint occlusionState);
}
