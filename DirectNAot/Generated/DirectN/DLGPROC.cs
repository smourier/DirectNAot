#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nint DLGPROC(HWND param0, uint param1, WPARAM param2, LPARAM param3);
