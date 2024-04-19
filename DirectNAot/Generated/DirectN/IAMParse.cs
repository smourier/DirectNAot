namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amparse/nn-amparse-iamparse
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c47a3420-005c-11d2-9038-00a0c9697298")]
public partial interface IAMParse
{
    // https://learn.microsoft.com/windows/win32/api/amparse/nf-amparse-iamparse-getparsetime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParseTime(out long prtCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/amparse/nf-amparse-iamparse-setparsetime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParseTime(long rtCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/amparse/nf-amparse-iamparse-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
}
