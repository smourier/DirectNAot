#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a300415a-54aa-4081-adbf-3b13610d8958")]
public partial interface IWMPNodeWindowedHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnWindowMessageFromRenderer(uint uMsg, WPARAM wparam, LPARAM lparam, ref LRESULT plRet, ref BOOL pfHandled);
}
