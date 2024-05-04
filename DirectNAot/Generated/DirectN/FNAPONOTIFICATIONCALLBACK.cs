#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT FNAPONOTIFICATIONCALLBACK(nint pProperties, nint pvRefData);
