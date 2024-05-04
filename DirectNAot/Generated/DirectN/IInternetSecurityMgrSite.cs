#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("79eac9ed-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IInternetSecurityMgrSite
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(out HWND phwnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModeless([MarshalAs(UnmanagedType.U4)] bool fEnable);
}
