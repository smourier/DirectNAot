#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_VIDEOPROCESSENDFRAME(HANDLE hDevice, nint pHandleComplete);
