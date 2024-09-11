#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
public partial interface IDxcContainerBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pDxilContainerHeader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPart(uint fourCC, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pSource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePart(uint fourCC);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SerializeContainer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult);
}
