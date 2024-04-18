namespace DirectN;

[GeneratedComInterface, Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
public partial interface IDxcContainerBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Load(IDxcBlob pDxilContainerHeader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddPart(uint fourCC, IDxcBlob pSource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemovePart(uint fourCC);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SerializeContainer(out IDxcOperationResult ppResult);
}
