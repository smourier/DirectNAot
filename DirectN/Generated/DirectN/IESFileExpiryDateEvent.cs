#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesfileexpirydateevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ba9edcb6-4d36-4cfe-8c56-87a6b0ca48e1")]
public partial interface IESFileExpiryDateEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-gettunerid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTunerId(out Guid pguidTunerId);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-getexpirydate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExpiryDate(out ulong pqwExpiryDate);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-getfinalexpirydate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFinalExpiryDate(out ulong pqwExpiryDate);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-getmaxrenewalcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxRenewalCount(out uint dwMaxRenewalCount);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-isentitlementtokenpresent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEntitlementTokenPresent(out BOOL pfEntTokenPresent);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesfileexpirydateevent-doesexpireafterfirstuse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesExpireAfterFirstUse(out BOOL pfExpireAfterFirstUse);
}
