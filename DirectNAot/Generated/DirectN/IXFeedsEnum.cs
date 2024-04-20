namespace DirectN;

[GeneratedComInterface, Guid("dc43a9d5-5015-4301-8c96-a47434b4d658")]
public partial interface IXFeedsEnum
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Count(out uint puiCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(uint uiIndex, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
}
