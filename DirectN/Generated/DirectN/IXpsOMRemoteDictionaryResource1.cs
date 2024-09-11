#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nn-xpsobjectmodel_1-ixpsomremotedictionaryresource1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bf8fc1d4-9d46-4141-ba5f-94bb9250d041")]
public partial interface IXpsOMRemoteDictionaryResource1 : IXpsOMRemoteDictionaryResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomremotedictionaryresource1-getdocumenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentType(out XPS_DOCUMENT_TYPE documentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsomremotedictionaryresource1-write1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISequentialStream>))] ISequentialStream stream, XPS_DOCUMENT_TYPE documentType);
}
