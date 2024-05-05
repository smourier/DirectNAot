#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFNGETACTIVATIONFACTORY(HSTRING param0, nint param1);
