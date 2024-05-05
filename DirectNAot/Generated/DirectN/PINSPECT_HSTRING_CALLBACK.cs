#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PINSPECT_HSTRING_CALLBACK(nint context, nuint readAddress, uint length, nint buffer);
