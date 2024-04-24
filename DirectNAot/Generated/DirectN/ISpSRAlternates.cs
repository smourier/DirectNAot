namespace DirectN;

[GeneratedComInterface, Guid("fece8294-2be1-408f-8e68-2de377092f0e")]
public partial interface ISpSRAlternates
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlternates(in SPPHRASEALTREQUEST pAltRequest, out nint ppAlts, out uint pcAlts);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit(in SPPHRASEALTREQUEST pAltRequest, in SPPHRASEALT pAlt, out nint ppvResultExtra, out uint pcbResultExtra);
}
