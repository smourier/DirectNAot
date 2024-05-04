#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfdrmnethelper
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3d1ff0ea-679a-4190-8d46-7fa69e8c7e15")]
public partial interface IMFDRMNetHelper
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfdrmnethelper-processlicenserequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessLicenseRequest(nint /* byte array */ pLicenseRequest, uint cbLicenseRequest, out nint /* byte array */ ppLicenseResponse, out uint pcbLicenseResponse, out BSTR pbstrKID);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfdrmnethelper-getchainedlicenseresponse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChainedLicenseResponse(out nint /* byte array */ ppLicenseResponse, out uint pcbLicenseResponse);
}
