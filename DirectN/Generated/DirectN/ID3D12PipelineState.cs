#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12pipelinestate
[GeneratedComInterface, Guid("765a30f3-f624-4c6f-a828-ace948622445")]
public partial interface ID3D12PipelineState : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinestate-getcachedblob
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCachedBlob([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBlob);
}
