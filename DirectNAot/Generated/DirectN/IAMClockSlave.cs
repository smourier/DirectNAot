namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamclockslave
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9fd52741-176d-4b36-8f51-ca8f933223be")]
public partial interface IAMClockSlave
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamclockslave-seterrortolerance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorTolerance(uint dwTolerance);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamclockslave-geterrortolerance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorTolerance(out uint pdwTolerance);
}
