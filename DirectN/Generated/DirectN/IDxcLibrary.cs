#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
public partial interface IDxcLibrary
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMalloc([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMalloc?>))] IMalloc? pMalloc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobFromBlob([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pBlob, uint offset, uint length, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobFromFile(PWSTR pFileName, nint /* optional DXC_CP* */ codePage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobWithEncodingFromPinned(nint pText, uint size, DXC_CP codePage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobWithEncodingOnHeapCopy(nint pText, uint size, DXC_CP codePage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobWithEncodingOnMalloc(nint pText, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMalloc>))] IMalloc pIMalloc, uint size, DXC_CP codePage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateIncludeHandler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcIncludeHandler>))] out IDxcIncludeHandler ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStreamFromBlobReadOnly([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pBlob, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlobAsUtf8([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pBlob, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlobAsWide([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pBlob, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding pBlobEncoding);
}
