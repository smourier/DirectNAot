#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12CompilerCacheSessionAllocationFunc(nuint SizeInBytes, nint pContext);
