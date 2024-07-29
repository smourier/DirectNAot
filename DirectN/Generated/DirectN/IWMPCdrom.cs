#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcdrom
[GeneratedComInterface, Guid("cfab6e98-8730-11d3-b388-00c04f68574b")]
public partial interface IWMPCdrom : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdrom-get_drivespecifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_driveSpecifier(ref BSTR pbstrDrive);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdrom-get_playlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playlist([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] out IWMPPlaylist ppPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdrom-eject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT eject();
}
