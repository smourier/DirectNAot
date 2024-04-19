namespace DirectN;

[GeneratedComInterface, Guid("9b9199ad-780c-4eda-b816-261eba5d1575")]
public partial interface IWMPNodeWindowless : IWMPWindowMessageSink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDraw(nint hdc, FoundationRECT prcDraw);
}
