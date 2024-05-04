#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPCONTROLCALLBACK(HWND hWnd, int nState);
