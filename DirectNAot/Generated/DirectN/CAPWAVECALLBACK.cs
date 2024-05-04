#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPWAVECALLBACK(HWND hWnd, nint /* in WAVEHDR */ lpWHdr);
