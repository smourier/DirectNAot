#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e8d907db-62a9-4a95-abe7-e01763dd30f8")]
public partial interface IXpsDocument
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartThumbnail>))] out IPartThumbnail ppThumbnail);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartThumbnail>))] IPartThumbnail pThumbnail);
}
