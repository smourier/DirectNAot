#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e15e9ad1-8f20-4cc4-9ec7-1a328ca86a0d")]
public partial interface IWMPDownloadManager : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getDownloadCollection(int lCollectionId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPDownloadCollection>))] out IWMPDownloadCollection ppCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT createDownloadCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPDownloadCollection>))] out IWMPDownloadCollection ppCollection);
}
