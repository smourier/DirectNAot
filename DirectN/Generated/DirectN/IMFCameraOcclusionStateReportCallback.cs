#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameraocclusionstatereportcallback
[GeneratedComInterface, Guid("6e5841c7-3889-4019-9035-783fb19b5948")]
public partial interface IMFCameraOcclusionStateReportCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraocclusionstatereportcallback-onocclusionstatereport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnOcclusionStateReport(IMFCameraOcclusionStateReport occlusionStateReport);
}
