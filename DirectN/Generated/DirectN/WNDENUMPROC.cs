#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL WNDENUMPROC(HWND param0, LPARAM param1);
