#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12CompilerCacheSessionGroupValuesFunc(uint ValueKeyIndex, nint /* in D3D12_COMPILER_CACHE_TYPED_CONST_VALUE */ pTypedValue, nint pContext);
