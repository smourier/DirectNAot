#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPERRORCALLBACKW(HWND hWnd, int nID, PWSTR lpsz);
