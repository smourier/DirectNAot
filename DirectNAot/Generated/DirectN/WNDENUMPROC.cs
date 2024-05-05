#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool WNDENUMPROC(HWND param0, LPARAM param1);
