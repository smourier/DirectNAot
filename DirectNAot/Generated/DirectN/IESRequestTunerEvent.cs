namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesrequesttunerevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("54c7a5e8-c3bb-4f51-af14-e0e2c0e34c6d")]
public partial interface IESRequestTunerEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesrequesttunerevent-getpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(nint /* byte array */ pbyPriority);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesrequesttunerevent-getreason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReason(nint /* byte array */ pbyReason);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesrequesttunerevent-getconsequences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConsequences(nint /* byte array */ pbyConsequences);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesrequesttunerevent-getestimatedtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEstimatedTime(out uint pdwEstimatedTime);
}
