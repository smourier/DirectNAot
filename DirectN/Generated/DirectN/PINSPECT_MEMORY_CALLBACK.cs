#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PINSPECT_MEMORY_CALLBACK(nint /* optional void* */ context, nuint readAddress, uint length, nint buffer);
