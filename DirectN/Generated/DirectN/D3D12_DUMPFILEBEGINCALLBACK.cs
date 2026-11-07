#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint D3D12_DUMPFILEBEGINCALLBACK(ulong flags);
