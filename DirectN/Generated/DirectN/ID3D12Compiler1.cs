#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e524f9f2-497e-43e2-9386-02d53bdc2d52")]
public partial interface ID3D12Compiler1 : ID3D12Compiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompilePipelineState1([In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] D3D12_COMPILER_CACHE_GROUP_KEY[] pGroupKeys, [In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] uint[] pVersions, uint NumGroupKeys, in D3D12_PIPELINE_STATE_STREAM_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileStateObject1([In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] D3D12_COMPILER_CACHE_GROUP_KEY[] pGroupKeys, [In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] uint[] pVersions, uint NumGroupKeys, in D3D12_STATE_OBJECT_DESC pDesc, in Guid riid, out nint /* void */ ppCompilerStateObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileAddToStateObject1([In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] D3D12_COMPILER_CACHE_GROUP_KEY[] pGroupKeys, [In][MarshalUsing(CountElementName = nameof(NumGroupKeys))] uint[] pVersions, uint NumGroupKeys, in D3D12_STATE_OBJECT_DESC pAddition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CompilerStateObject>))] ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, in Guid riid, out nint /* void */ ppNewCompilerStateObject);
}
