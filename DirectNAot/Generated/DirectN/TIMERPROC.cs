#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void TIMERPROC(HWND param0, uint param1, nuint param2, uint param3);
