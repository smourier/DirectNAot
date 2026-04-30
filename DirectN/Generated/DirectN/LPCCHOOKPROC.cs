#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nuint LPCCHOOKPROC(HWND param0, uint param1, WPARAM param2, LPARAM param3);
