namespace DirectN;

[GeneratedComInterface, Guid("cc350c00-095b-42a5-bf0f-c8780edadb3c")]
public partial interface IPartDiscardControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDiscardProperties(out BSTR uriSentinelPage, out BSTR uriPartToDiscard);
}
