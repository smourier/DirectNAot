#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ieslicenserenewalresultevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d5a48ef5-a81b-4df0-acaa-5e35e7ea45d4")]
public partial interface IESLicenseRenewalResultEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getcallersid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCallersId(out uint pdwCallersId);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileName(out BSTR pbstrFilename);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-isrenewalsuccessful
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRenewalSuccessful([MarshalAs(UnmanagedType.U4)] out bool pfRenewalSuccessful);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-ischeckentitlementcallrequired
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCheckEntitlementCallRequired([MarshalAs(UnmanagedType.U4)] out bool pfCheckEntTokenCallNeeded);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getdescrambledstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescrambledStatus(out uint pDescrambledStatus);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getrenewalresultcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenewalResultCode(out uint pdwRenewalResultCode);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getcasfailurecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCASFailureCode(out uint pdwCASFailureCode);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getrenewalhresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenewalHResult(out HRESULT phr);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getentitlementtokenlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntitlementTokenLength(out uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getentitlementtoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntitlementToken(out nint pbData);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieslicenserenewalresultevent-getexpirydate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExpiryDate(out ulong pqwExpiryDate);
}
