#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDENUMSURFACESCALLBACK7(nint /* IDirectDrawSurface7 */ param0, nint param1, nint param2);
