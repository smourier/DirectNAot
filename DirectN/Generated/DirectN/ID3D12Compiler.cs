#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8c403c12-993b-4583-80f1-6824138fa68e")]
public partial interface ID3D12Compiler : ID3D12CompilerFactoryChild
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompilePipelineState(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, uint GroupVersion, in D3D12_PIPELINE_STATE_STREAM_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileStateObject(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, uint GroupVersion, in D3D12_STATE_OBJECT_DESC pDesc, in Guid riid, out nint /* void */ ppCompilerStateObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileAddToStateObject(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, uint GroupVersion, in D3D12_STATE_OBJECT_DESC pAddition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CompilerStateObject>))] ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, in Guid riid, out nint /* void */ ppNewCompilerStateObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCacheSession(in Guid riid, out nint /* void */ ppCompilerCacheSession);
}
