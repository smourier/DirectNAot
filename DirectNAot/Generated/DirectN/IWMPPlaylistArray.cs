namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplaylistarray
[GeneratedComInterface, Guid("679409c0-99f7-11d3-9fb7-00105aa620bb")]
public partial interface IWMPPlaylistArray : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistarray-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistarray-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(int lIndex, out IWMPPlaylist ppItem);
}
