#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1c5789ff-9203-490f-b971-984acf1eb5fe")]
public partial interface ID3D12ShaderCacheSession1 : ID3D12ShaderCacheSession
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindValue1(in D3D12_CACHE_VALUE_KEY pValueKey, [In][Out][MarshalUsing(CountElementName = nameof(NumTypedValues))] D3D12_CACHE_TYPED_VALUE[] pTypedValues, uint NumTypedValues, D3D12CacheSessionAllocationFunc? pCallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreValue1(in D3D12_CACHE_VALUE_KEY pValueKey, [In][MarshalUsing(CountElementName = nameof(NumTypedValues))] D3D12_CACHE_TYPED_CONST_VALUE[] pTypedValues, uint NumTypedValues, D3D12_SHADER_CACHE_STORE_FLAGS Flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSessionInfo(out D3D12_SHADER_CACHE_SESSION_INFO pInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TrimTo(ulong SizeBytes, D3D12_SHADER_CACHE_TRIM_FLAGS Flags);
}
