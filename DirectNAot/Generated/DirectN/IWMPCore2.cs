namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcore2
[GeneratedComInterface, Guid("bc17e5b7-7561-4c18-bb90-17d485775659")]
public partial interface IWMPCore2 : IWMPCore
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore2-get_dvd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_dvd(out IWMPDVD ppDVD);
}
