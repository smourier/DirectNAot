#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nuint LPOFNHOOKPROC(HWND param0, uint param1, WPARAM param2, LPARAM param3);
