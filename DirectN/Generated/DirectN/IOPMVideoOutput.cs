#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/nn-opmapi-iopmvideooutput
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0a15159d-41c7-4456-93e1-284cd61d4e8d")]
public partial interface IOPMVideoOutput
{
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-iopmvideooutput-startinitialization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartInitialization(out OPM_RANDOM_NUMBER prnRandomNumber, out nint /* byte array */ ppbCertificate, out uint pulCertificateLength);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-iopmvideooutput-finishinitialization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinishInitialization(in OPM_ENCRYPTED_INITIALIZATION_PARAMETERS pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-iopmvideooutput-getinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInformation(in OPM_GET_INFO_PARAMETERS pParameters, out OPM_REQUESTED_INFORMATION pRequestedInformation);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-iopmvideooutput-coppcompatiblegetinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT COPPCompatibleGetInformation(in OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS pParameters, out OPM_REQUESTED_INFORMATION pRequestedInformation);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-iopmvideooutput-configure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Configure(in OPM_CONFIGURE_PARAMETERS pParameters, uint ulAdditionalParametersSize, nint /* optional byte* */ pbAdditionalParameters);
}
