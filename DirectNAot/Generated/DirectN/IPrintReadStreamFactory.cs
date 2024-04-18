namespace DirectN;

[GeneratedComInterface, Guid("acb971e3-df8d-4fc2-bee6-0609d15f3cf9")]
public partial interface IPrintReadStreamFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStream(out IPrintReadStream ppStream);
}
