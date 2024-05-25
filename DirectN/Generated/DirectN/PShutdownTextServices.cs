#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PShutdownTextServices(nint /* nint */ pTextServices);
