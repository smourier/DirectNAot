#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PINSPECT_HSTRING_CALLBACK2(nint context, ulong readAddress, uint length, nint buffer);
