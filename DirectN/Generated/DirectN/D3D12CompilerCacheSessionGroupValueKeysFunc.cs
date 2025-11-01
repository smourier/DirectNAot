#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12CompilerCacheSessionGroupValueKeysFunc(nint /* in D3D12_COMPILER_CACHE_VALUE_KEY */ pValueKey, nint pContext);
