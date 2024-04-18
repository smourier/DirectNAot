namespace DirectN;

[GeneratedComInterface, Guid("b8cf8530-5562-47c4-ab67-b1f69ecf961e")]
public partial interface IXpsDocumentProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetXpsPart(out nint ppIXpsPart);
}
