namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltermapper3
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b79bb0b1-33c1-11d1-abe1-00a0c905f375")]
public partial interface IFilterMapper3 : IFilterMapper2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper3-geticreatedevenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetICreateDevEnum(out ICreateDevEnum ppEnum);
}
