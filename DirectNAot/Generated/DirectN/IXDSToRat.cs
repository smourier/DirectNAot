namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tvratings/nn-tvratings-ixdstorat
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5c5c5b0-3abc-11d6-b25b-00c04fa0c026")]
public partial interface IXDSToRat : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ixdstorat-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init();
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ixdstorat-parsexdsbytepair
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseXDSBytePair(byte byte1, byte byte2, out EnTvRat_System pEnSystem, out EnTvRat_GenericLevel pEnLevel, out int plBfEnAttributes);
}
