#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL MONITORENUMPROC(HMONITOR param0, HDC param1, nint param2, LPARAM param3);
