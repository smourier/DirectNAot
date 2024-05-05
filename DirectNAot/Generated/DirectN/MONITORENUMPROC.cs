#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool MONITORENUMPROC(HMONITOR param0, HDC param1, nint param2, LPARAM param3);
