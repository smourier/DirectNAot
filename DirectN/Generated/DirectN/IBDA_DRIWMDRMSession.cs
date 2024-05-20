#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("05c690f8-56db-4bb2-b053-79c12098bb26")]
public partial interface IBDA_DRIWMDRMSession
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcknowledgeLicense(HRESULT hrLicenseAck);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessLicenseChallenge(uint dwcbLicenseMessage, nint /* byte array */ pbLicenseMessage, ref uint pdwcbLicenseResponse, out nint /* byte array */ ppbLicenseResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessRegistrationChallenge(uint dwcbRegistrationMessage, nint /* byte array */ pbRegistrationMessage, ref uint pdwcbRegistrationResponse, out nint /* byte array */ ppbRegistrationResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRevInfo(uint dwRevInfoLen, nint /* byte array */ pbRevInfo, ref uint pdwResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCrl(uint dwCrlLen, nint /* byte array */ pbCrlLen, ref uint pdwResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHMSAssociationData();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastCardeaError(ref uint pdwError);
}
