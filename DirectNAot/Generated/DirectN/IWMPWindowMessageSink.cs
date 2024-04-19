namespace DirectN;

[GeneratedComInterface, Guid("3a0daa30-908d-4789-ba87-aed879b5c49b")]
public partial interface IWMPWindowMessageSink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnWindowMessage(uint uMsg, WPARAM wparam, LPARAM lparam, ref LRESULT plRet, [MarshalAs(UnmanagedType.U4)] ref bool pfHandled);
}
