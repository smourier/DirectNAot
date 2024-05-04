#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDGAMMACALIBRATORPROC(nint param0, nint param1);
