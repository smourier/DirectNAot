#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("76cff76f-1e9b-4450-8cdc-34f1af788e5b")]
public partial interface ID3D12Device15 : ID3D12Device14
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTrimNotificationCallback(ref D3D12_REGISTER_TRIM_NOTIFICATION pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterTrimNotificationCallback(uint CallbackCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateShaderResourceView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pResource, nint /* optional D3D12_SHADER_RESOURCE_VIEW_DESC* */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateUnorderedAccessView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pCounterResource, nint /* optional D3D12_UNORDERED_ACCESS_VIEW_DESC* */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateConstantBufferView(nint /* optional D3D12_CONSTANT_BUFFER_VIEW_DESC* */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateSampler2(in D3D12_SAMPLER_DESC2 pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateRenderTargetView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pResource, nint /* optional D3D12_RENDER_TARGET_VIEW_DESC* */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateDepthStencilView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pResource, nint /* optional D3D12_DEPTH_STENCIL_VIEW_DESC* */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryCreateSamplerFeedbackUnorderedAccessView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pTargetedResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pFeedbackResource, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryHeap1(in D3D12_QUERY_HEAP_DESC pDesc, D3D12_QUERY_HEAP_FLAGS Flags, in Guid riid, out nint /* void */ ppvHeap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResolveQueryData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12QueryHeap>))] ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, nint pResolvedQueryData);
}
