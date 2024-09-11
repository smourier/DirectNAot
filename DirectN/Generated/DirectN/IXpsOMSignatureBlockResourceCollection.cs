#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomsignatureblockresourcecollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ab8f5d8e-351b-4d33-aaed-fa56f0022931")]
public partial interface IXpsOMSignatureBlockResourceCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] out IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertAt(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAt(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] IXpsOMSignatureBlockResource signatureBlockResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsignatureblockresourcecollection-getbypartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetByPartName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSignatureBlockResource>))] out IXpsOMSignatureBlockResource signatureBlockResource);
}
