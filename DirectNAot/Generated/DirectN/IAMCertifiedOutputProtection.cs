namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamcertifiedoutputprotection
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6feded3e-0ff1-4901-a2f1-43f7012c8515")]
public partial interface IAMCertifiedOutputProtection
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcertifiedoutputprotection-keyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyExchange(out Guid pRandom, out nint /* byte array */ VarLenCertGH, out uint pdwLengthCertGH);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcertifiedoutputprotection-sessionsequencestart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SessionSequenceStart(in AMCOPPSignature pSig);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcertifiedoutputprotection-protectioncommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProtectionCommand(in AMCOPPCommand cmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcertifiedoutputprotection-protectionstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProtectionStatus(in AMCOPPStatusInput pStatusInput, out AMCOPPStatusOutput pStatusOutput);
}
