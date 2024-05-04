#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
public partial interface IDxcContainerBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(IDxcBlob pDxilContainerHeader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPart(uint fourCC, IDxcBlob pSource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePart(uint fourCC);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SerializeContainer(out IDxcOperationResult ppResult);
}
