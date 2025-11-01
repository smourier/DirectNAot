#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5704e5e6-054b-4738-b661-7b0d68d8dde2")]
public partial interface ID3D12CompilerCacheSession : ID3D12CompilerFactoryChild
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindGroup(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, nint /* optional uint* */ pGroupVersion);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindGroupValueKeys(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, nint /* optional uint* */ pExpectedGroupVersion, D3D12CompilerCacheSessionGroupValueKeysFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindGroupValues(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, nint /* optional uint* */ pExpectedGroupVersion, D3D12_COMPILER_VALUE_TYPE_FLAGS ValueTypeFlags, D3D12CompilerCacheSessionGroupValuesFunc? CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindValue(in D3D12_COMPILER_CACHE_VALUE_KEY pValueKey, [In][Out][MarshalUsing(CountElementName = nameof(NumTypedValues))] D3D12_COMPILER_CACHE_TYPED_VALUE[] pTypedValues, uint NumTypedValues, D3D12CompilerCacheSessionAllocationFunc? pCallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    nint GetApplicationDesc();
    
    [PreserveSig]
    D3D12_COMPILER_TARGET GetCompilerTarget();
    
    [PreserveSig]
    D3D12_COMPILER_VALUE_TYPE_FLAGS GetValueTypes();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreGroupValueKeys(in D3D12_COMPILER_CACHE_GROUP_KEY pGroupKey, uint GroupVersion, [In][MarshalUsing(CountElementName = nameof(NumValueKeys))] D3D12_COMPILER_CACHE_VALUE_KEY[] pValueKeys, uint NumValueKeys);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreValue(in D3D12_COMPILER_CACHE_VALUE_KEY pValueKey, [In][MarshalUsing(CountElementName = nameof(NumTypedValues))] D3D12_COMPILER_CACHE_TYPED_CONST_VALUE[] pTypedValues, uint NumTypedValues);
}
